using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriLabFour
{
    public class Cube : Square
    {
        public double Height { get; set; }

        public Cube(double x, double y, double side, double height) : base(x, y, side)
        {
            Height = height;
        }
    }
}
