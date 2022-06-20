using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.App
{
    public class Rectangel : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public override double GetPerimeter() => SideA * 2 + SideB * 2;
        public override double GetSquare() => SideA * SideB;
        
    }
}
