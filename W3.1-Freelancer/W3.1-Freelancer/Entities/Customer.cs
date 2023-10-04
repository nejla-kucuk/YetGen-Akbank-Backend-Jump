using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3._1_Freelancer.Abstract;
using W3._1_Freelancer.Common;

namespace W3._1_Freelancer.Entities
{
    public class Customer : Person<Guid> , ICsvConvertible
    {

        public string PhoneNumber { get; set; }

        public Customer()
        {

        }

        public string GetValuesCSV()
        {
            return $"{Id},{CreatedOn},{FirstName},{LastName},{PhoneNumber}";
        }


        public void SetValuesCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName = data[2];
            LastName = data[3];
            PhoneNumber = data[4];
        }
    }
}
