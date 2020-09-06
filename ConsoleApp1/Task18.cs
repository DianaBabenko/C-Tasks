using System;

namespace ConsoleApp1
{
    public class Task18
    {
        public void Main18()
        {
            double a1 = 50;
            double a2 = 50;
            double a3 = 50;
            double r = 120;
            double a = 2 * r * Math.Sin(a1 * Math.PI / 180);
            double b = 2 * r * Math.Sin(a2 * Math.PI / 180);
            double c = 2 * r * Math.Sin(a3 * Math.PI / 180);

            Console.WriteLine("A :" + a);
            Console.WriteLine("B :" + b);
            Console.WriteLine("C :" + c);
        }
    }
}