using System;

namespace ConsoleApp1
{
    public class Task29
    {
        public void Main29()
        {
            double x = 4;
            double y = 2;
            double q = 3 * Math.Pow(x, 2) * Math.Pow(y, 2) - (2 * x) * Math.Pow(y, 2) - 7 * Math.Pow(x, 2) * y
                - 4 * Math.Pow(y, 2) + 15 * x * y + 2 * Math.Pow(x, 2) - 3 * x + 10 * y + 6;
            Console.WriteLine("Q = " + q);
        }
    }
}