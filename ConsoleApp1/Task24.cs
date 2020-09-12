using System;

namespace ConsoleApp1
{
    public class Task24
    {
        public void Main24()
        {
            double x1 = 1;
            double y1 = 2;
            double x2 = 1;
            double y2 = 4;
            double l = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("l = " + l);
        }
    }
}