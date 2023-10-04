using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3._1_Freelancer.Constants
{
    public static class FileLocation
    {
        public static string ProjectFolder => Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;
    }
}
