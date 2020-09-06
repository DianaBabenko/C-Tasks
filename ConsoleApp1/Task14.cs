using System;

namespace ConsoleApp1
{
    public class Task14
    {
        public void Main14()
        {
            Console.Write("Введіть значення m1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введіть значення m2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введіть значення r: ");
            int r = Convert.ToInt32(Console.ReadLine());

            double g = 6.61 * Math.Pow(10, -11);

            double f = g * m1 * m2 / Math.Pow(r, 2);

            Console.WriteLine("F = " + f);
        }
    }
}