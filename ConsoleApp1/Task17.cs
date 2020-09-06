using System;

namespace ConsoleApp1
{
    public class Task17
    {
        public void Main17()
        {
            double rv = 20;
            double rz = 30;
            double sv = Math.PI * Math.Pow(rv, 2);
            double sz = Math.PI * Math.Pow(rz, 2);
            double s = sz - sv;

            Console.WriteLine("Площа :" + s);
        }
    }
}