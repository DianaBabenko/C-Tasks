using System;

namespace ConsoleApp1
{
    public class Task19
    {
        public void Main19()
        {
            double v1 = 6;
            double v2 = 8;
            double a1 = 1;
            double a2 = 5;
            double s = 1000;
            double t = (-(v1 + v2) + Math.Sqrt(Math.Pow((v1 + v2), 2) + 4 * ((a1 + a2) / 2) * s)) / (2 * (a1 + a2) / 2);

            Console.WriteLine("Час :" + t);
        }
    }
}