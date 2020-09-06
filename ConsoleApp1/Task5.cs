using System;

namespace ConsoleApp1
{
    public class Task5
    {
        public void Main5()
        {
            Console.Write("Введіть перше число: ");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            var y = Convert.ToInt32(Console.ReadLine());

            var avg = (Math.Abs(x) + Math.Abs(y)) / 2;
            var geom_sum = Math.Pow(Math.Abs(x) * Math.Abs(y), 0.5);

            Console.WriteLine("Середнє значення: " + avg);
            Console.WriteLine("Середнє геометричне значення: " + geom_sum);
        }
    }
}