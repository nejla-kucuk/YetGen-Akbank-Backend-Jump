using BankAccount.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Persistence.Context
{
    public class PerfectAppDbContext:DbContext
    {

        public DbSet<BankAccounts> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("PerfectApp");
        }

    }
}
