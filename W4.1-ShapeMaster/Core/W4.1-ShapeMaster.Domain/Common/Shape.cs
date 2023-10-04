using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W4._1_ShapeMaster.Domain.Abstract;

namespace W4._1_ShapeMaster.Domain.Common
{
    public abstract class Shape : EntityBase<Guid>, ISaveable
    {

        public string Type { get; set; }

        public string GetInfo()
        {
            return $"{Type} AREA: {GetArea}";
        }

        public abstract decimal GetArea();

    }
}
