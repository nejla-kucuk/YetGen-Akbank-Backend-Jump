using BankAccount.Domain.Entities;
using BankAccount.Persistence.Context;
using BankAccount.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankAccount.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : Controller
    {
        public PerfectAppDbContext _perfectAppDbContext;

        public BankAccountsController(PerfectAppDbContext perfectAppDbContext)
        {
            _perfectAppDbContext = perfectAppDbContext;
        }

        [HttpPost("[action]")]
        public void SetDefaultUsersData()
        {
            List<BankAccounts> people = new()
            {
                new BankAccounts {Id=Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DA"), CreatedOn = DateTime.UtcNow,
                    CreatedByUserId="1", FirstName="James",LastName="Smith",PhoneNumber="5007854959"},

                new BankAccounts {Id=Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DB"), CreatedOn = DateTime.UtcNow,
                    CreatedByUserId="1", FirstName="John",LastName="Doe",PhoneNumber="5856021548"},

                new BankAccounts {Id=Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DC"), CreatedOn = DateTime.UtcNow,
                    CreatedByUserId="1", FirstName="Alice",LastName="Johnson",PhoneNumber="5267854900"}
            };

            _perfectAppDbContext.People.AddRange(people);

            _perfectAppDbContext.SaveChanges();
        }


        [HttpGet("[action]/{bankAccountId:guid}")]
        public GetBankAccountDataResponseModel GetBankAccountData(Guid bankAccountId) 
        {
            var bankAccount = _perfectAppDbContext.People.FirstOrDefault(x => x.Id == bankAccountId);

            var response = new GetBankAccountDataResponseModel()
            {
                Balance = bankAccount.Balance,
                LastName = bankAccount.LastName,
                FirstName = bankAccount.FirstName
            };
            return response;
        }
    }
    
}
