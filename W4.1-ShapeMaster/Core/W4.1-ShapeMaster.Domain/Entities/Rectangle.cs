using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W4._1_ShapeMaster.Domain.Common;

namespace W4._1_ShapeMaster.Domain.Entities
{
    public class Rectangle : Shape
    {
        public decimal Aside { get; set; }

        public decimal Bside { get; set; }

        public Rectangle()
        {
            Type = "Rectangle";
        }

        public override decimal GetArea()
        {
            return Aside * Bside;
        }
    }
}
