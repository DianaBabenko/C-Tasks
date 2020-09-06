using System;

namespace ConsoleApp1
{
    public class Task22
    {
        public void Main22()
        {
            double a = 7;
            double b = 10;
            double u = 30;
            double h = (a - b) * Math.Sin(u) / (2 * Math.Cos(u));
            double s = (a + b) * h / 2;
            
            Console.WriteLine("Результат :" + s);
        }
    }
}