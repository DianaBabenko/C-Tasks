using System;

namespace ConsoleApp1
{
    public class Task21
    {
        public void Main21()
        {
            double c = 6;
            double d = 9;
            double d1 = Math.Pow(3, 2) + 4 * c * d;
            double x1 = (3 + Math.Sqrt(d1)) / 2;
            double x2 = (3 - Math.Sqrt(d1)) / 2;
            double a = Math.Abs(Math.Pow(Math.Sin(c * Math.Pow(x1, 3) + d * Math.Pow(x2, 2) - c * d), 3) /
                                Math.Sqrt(Math.Pow((c * Math.Pow(x1, 3) + d * Math.Pow(x2, 2) - x1), 2) + 3.14)) + Math.Tan(c * Math.Pow(x1, 3) + d * Math.Pow(x2, 2) - x1);

            Console.WriteLine("Результат :" + a);
        }
    }
}