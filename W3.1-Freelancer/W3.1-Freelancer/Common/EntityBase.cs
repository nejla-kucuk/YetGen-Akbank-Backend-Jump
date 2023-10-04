using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3._1_Freelancer.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
