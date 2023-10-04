using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3._1_Freelancer.Common
{
    public class Person <TKey> : EntityBase<TKey>
    {
       
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
