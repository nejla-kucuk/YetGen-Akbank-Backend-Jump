using Lecture.Application.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbSet<T> table => throw new NotImplementedException();
    }
}
