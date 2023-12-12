using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriLabFour
{
    public class Line
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public Line(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Линия:");
            StartPoint.PrintInfo();
            EndPoint.PrintInfo();
        }
    }
}
