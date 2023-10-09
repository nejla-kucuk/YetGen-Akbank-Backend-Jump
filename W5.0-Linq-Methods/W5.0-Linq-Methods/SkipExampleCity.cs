using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5._0_Linq_Methods
{
    public class SkipExampleCity
    {

        string[] names = { "Trabzon", "Oslo", "New York", "İstanbul", "Paris", "Adana", "London" };


        public void GetSkipExample()
        {
            foreach (var name in names.Skip(4))
            {
                Console.WriteLine(name); 
            }
        }
    }
}
