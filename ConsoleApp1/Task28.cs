using System;

namespace ConsoleApp1
{
    public class Task28
    {
        public void Main28()
        {
            double x = 4;
            double q = Math.Pow((2 * x), 4) - Math.Pow((3 * x), 3) + Math.Pow((4 * x), 2) - 5 * x + 6;
            Console.WriteLine("Q = " + q);
        }
    }
}