using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriLabFour
{
    public class Tetrahedron : Triangle
    {
        public double Height { get; set; }

        public Tetrahedron(double x1, double y1, double x2, double y2, double x3, double y3, double height) : base(x1, y1, x2, y2, x3, y3)
        {
            Height = height;
        }
    }
}
