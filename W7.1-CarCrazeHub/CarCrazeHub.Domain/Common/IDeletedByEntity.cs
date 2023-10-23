using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCrazeHub.Domain.Common
{
    public interface IDeletedByEntity
    {
        DateTime? DeletedOn { get; set; }
        string? DeletedByUserId { get; set; }
        bool? IsDeleted { get; set; }
    }
}
