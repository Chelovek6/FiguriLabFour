using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriLabFour
{
    public class Cube
    {
        public Square BaseSquare { get; set; }
        public double Height { get; set; }

        public Cube(Square baseSquare, double height)
        {
            BaseSquare = baseSquare;
            Height = height;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Cube: Height = {Height}");
            BaseSquare.PrintInfo();
        }
    }

}
