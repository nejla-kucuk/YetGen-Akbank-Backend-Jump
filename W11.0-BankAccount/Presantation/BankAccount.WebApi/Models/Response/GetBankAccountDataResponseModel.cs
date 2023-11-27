using Microsoft.AspNetCore.Mvc;

namespace BankAccount.WebApi.Models.Response
{

    public class GetBankAccountDataResponseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
    }
}
