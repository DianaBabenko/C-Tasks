using System;

namespace ConsoleApp1
{
    public class Task20
    {
        public void Main20()
        {
            double a1 = 2.4;
            double n = 16;
            double d = 3.9;
            double an = a1 + (n - 1) * d;
            double sn = ((a1 + an) * n) / 2;
            
            Console.WriteLine("Сума арифметичної прогресії :" + sn);
        }
    }
}