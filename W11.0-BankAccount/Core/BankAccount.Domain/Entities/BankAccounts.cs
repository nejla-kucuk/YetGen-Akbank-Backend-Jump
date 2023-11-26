using BankAccount.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Domain.Entities
{
    public class BankAccounts : EntityBase<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

       
        public string PhoneNumber { get; set; }

        public decimal Balance { get; set; }
    }
}
