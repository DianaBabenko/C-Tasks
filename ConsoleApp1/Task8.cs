using System;

namespace ConsoleApp1
{
    public class Task8
    {
        public void Main8()
        {
            Console.Write("Введіть значення n-кутів: ");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть значення радіусу: ");
            var r = Convert.ToInt32(Console.ReadLine());

            var perimeter = 2 * n * r * Math.Sin(Math.PI / n);

            Console.WriteLine("Периметр: " + perimeter);
        }
    }
}