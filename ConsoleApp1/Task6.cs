using System;

namespace ConsoleApp1
{
    public class Task6
    {
        public void Main6()
        {
            Console.Write("Введіть значення першого катету: ");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть значення другого катету: ");
            var y = Convert.ToInt32(Console.ReadLine());

            var hypotenuse = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            var square = x * y / 2;

            Console.WriteLine("Гіпотенуза: " + hypotenuse);
            Console.WriteLine("Площа: " + square);
        }
    }
}