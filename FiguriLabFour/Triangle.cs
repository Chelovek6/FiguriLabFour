using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriLabFour
{
    public class Triangle : Line
    {
        public Triangle(Point startPoint, Point endPoint, Point thirdPoint) : base(startPoint, endPoint)
        {
            
        }

        public new void PrintInfo() 
        {
            Console.WriteLine("Треугольник:");
            base.PrintInfo();
        }
    }

}
