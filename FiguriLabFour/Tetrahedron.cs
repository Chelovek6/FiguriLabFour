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

        public Tetrahedron(Point startPoint, Point endPoint, Point thirdPoint, double height)
            : base(startPoint, endPoint, thirdPoint)
        {
            Height = height;
        }

        public new void PrintInfo() 
        {
            Console.WriteLine($"Tetrahedron: Height = {Height}");
            base.PrintInfo();
        }
    }
}
