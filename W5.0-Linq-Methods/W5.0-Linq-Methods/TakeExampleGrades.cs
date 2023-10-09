using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5._0_Linq_Methods
{
    public class TakeExampleGrades
    {
        int[] grades = { 59, 82, 70, 56, 92, 98, 85 };


        public void GetTakeExample()
        {
            IEnumerable<int> topThreeGrades = grades
                                              .Take(3);

            foreach (int grade in topThreeGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
