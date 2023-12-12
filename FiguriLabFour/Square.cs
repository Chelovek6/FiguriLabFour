using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriLabFour
{
    public class Square
    {
        public Line Side { get; set; }

        public Square(Line side)
        {
            Side = side;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Квадрат:");
            Side.PrintInfo();
        }
    }
}
