using System;

namespace ConsoleApp1
{
    public class Task25
    {
        public void Main25()
        {
            double x1 = 1;
            double y1 = 2;
            double x2 = 3;
            double y2 = 5;
            double x3 = 5;
            double y3 = 10;
            
            double st1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            double st2 = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
            double st3 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            
            double p = st1 + st2 + st3;
            double half = p / 2;
            double s = Math.Sqrt(half * (half - st1) * (half - st2) * (half - st3));
            
            Console.WriteLine("Площа S = " + s +" Периметер P = " + p);
        }
    }
}