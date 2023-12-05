using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriLabFour
{
    public class Square : Line
    {
        public double Side { get; set; }

        public Square(double x, double y, double side) : base(x, y, x + side, y)
        {
            Side = side;
        }
    }
}
