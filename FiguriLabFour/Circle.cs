using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriLabFour
{
    public class Circle : Point
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }
    }
}
