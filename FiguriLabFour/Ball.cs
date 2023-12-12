using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriLabFour
{
    public class Ball : Circle
    {
        public double Volume { get; set; }

        public Ball(double x, double y, double radius) : base(x, y, radius)
        {
            
        }
    }
}
