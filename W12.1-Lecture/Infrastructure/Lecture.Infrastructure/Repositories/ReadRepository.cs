using Lecture.Application.Abstract;
using Lecture.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Infrastructure.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : EntityBase
    {
        public DbSet<T> Table => throw new NotImplementedException();

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
