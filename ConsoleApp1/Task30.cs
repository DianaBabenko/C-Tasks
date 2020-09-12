using System;

namespace ConsoleApp1
{
    public class Task30
    {
        public void Main30()
        {
            double x = 4;
            double q = 1 - 2 * x + 3 * Math.Pow(x, 2) - 4 * Math.Pow(x, 3);
            double z = 1 + 2 * x + 3 * Math.Pow(x, 2) - 4 * Math.Pow(x, 3);
            Console.WriteLine("Q = " + q +" Z = " + z);
        }
    }
}