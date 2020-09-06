using System;

namespace ConsoleApp1
{
    public class Task3
    {
        public void Main3()
        {
            Console.Write("Ребро куба: ");
            int x = Convert.ToInt32(Console.ReadLine());

            double v = Math.Pow(x, 3);
            double s = Math.Pow(x, 2);
            Console.WriteLine("Об'єм: " + v);
            Console.WriteLine("Площа: " + s);
        }
    }
}