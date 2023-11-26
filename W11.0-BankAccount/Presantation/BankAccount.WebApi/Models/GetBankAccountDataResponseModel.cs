using Microsoft.AspNetCore.Mvc;

namespace BankAccount.WebApi.Models
{

    public class GetBankAccountDataResponseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
    }
}
