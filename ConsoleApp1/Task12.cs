using System;

namespace ConsoleApp1
{
    public class Task12
    {
        public void Main12()
        {
            Console.Write("Введіть значення сторони: ");
            int side = Convert.ToInt32(Console.ReadLine());

            double square = (Math.Pow(side, 2) * (Math.Sqrt(3))) / 4;

            Console.WriteLine("Площа : " + square);
        }
    }
}