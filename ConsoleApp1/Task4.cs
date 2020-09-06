using System;

namespace ConsoleApp1
{
    public class Task4
    {
        public void Main4()
        {
            Console.Write("Введіть перше позитивне дійсне число: ");
            var x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введіть друге позитивне дійсне число: ");
            var y = Convert.ToInt32(Console.ReadLine());

            var avg = (x + y) / 2;
            var geom_sum = Math.Pow(x * y, 0.5);
            
            Console.WriteLine("Середнє значення: " + avg);
            Console.WriteLine("Середнє геометричне значення: " + geom_sum);
        }
    }
}