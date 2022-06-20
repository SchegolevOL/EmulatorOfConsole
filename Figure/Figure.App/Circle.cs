using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure.App
{
    public class Circle : Figure
    {
        public const double PI = 3.14;
        public double Radius { get; set; }
        public override double GetPerimeter()=>2*PI*Radius;
        

        public override double GetSquare()=>PI*Radius*Radius;
       
    }
}
