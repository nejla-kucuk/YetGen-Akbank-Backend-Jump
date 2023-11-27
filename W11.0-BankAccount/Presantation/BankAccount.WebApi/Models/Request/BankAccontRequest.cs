using BankAccount.WebApi.Models.ModelMetadataTypes;
using Microsoft.AspNetCore.Mvc;

namespace BankAccount.WebApi.Models.Request
{
    [ModelMetadataType(typeof(BankAccountMetadata))]
    public class BankAccontRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
    }
}
