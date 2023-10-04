using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4._1_ShapeMaster.Domain.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }

        public DateTimeOffset createdOn { get; set; }
    }
}
