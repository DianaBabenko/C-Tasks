using System;

namespace ConsoleApp1
{
    public class Task10
    {
        public void Main10()
        {
            double g = 9.8;

            Console.Write("Введіть значення h: ");
            double height = Convert.ToInt32(Console.ReadLine());

            double time = ((2 * height) / g);

            Console.WriteLine("Час падіння: " + time);
        }
    }
}