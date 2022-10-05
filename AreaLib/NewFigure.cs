using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class NewFigure : Figure
    {
        public double Area { get; set; }

        public override double CalcArea()
        {
            return Area;
        }
    }
}
