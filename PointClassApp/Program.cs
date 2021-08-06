using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointClassApp.Model;

namespace PointClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 5);
            UpdatePoints(p1);
            PrintDetails(p1);
            Console.ReadLine();
        }
        static void UpdatePoints(Point obj)
        {
            obj.X = 12;
            obj.Y = 10;
        }

        static void PrintDetails(Point obj)
        {
            Console.WriteLine("X-axis Point: " + obj.X);
            Console.WriteLine("Y-axis Point: " + obj.Y);
        }
    }
}
