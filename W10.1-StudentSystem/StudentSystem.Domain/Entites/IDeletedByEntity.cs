using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Domain.Entites
{
    public interface IDeletedByEntity
    {
        public bool IsDeleted { get; set; }

        public string? DeletedByUserId { get; set; }

        public DateTimeOffset? DeletedOn { get; set; }
    }
}
