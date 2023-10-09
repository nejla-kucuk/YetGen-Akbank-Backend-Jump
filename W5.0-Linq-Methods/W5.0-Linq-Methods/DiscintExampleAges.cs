using System;
using System.Collections.Generic;
using System.Linq;

namespace W5._0_Linq_Methods
{
    public class DiscintExampleAges
    {
        List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };


        public void GetDistinctExample()
        {
            IEnumerable<int> distinctAges = ages.Distinct();

            foreach (int age in distinctAges)
            {
                Console.WriteLine(age);
            }
        }
    }
}
