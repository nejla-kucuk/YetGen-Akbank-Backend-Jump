using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3._1_Freelancer.Abstract
{
    public interface ICsvConvertible
    {
        string GetValuesCSV();
        void SetValuesCSV(string csv);
    }
}
