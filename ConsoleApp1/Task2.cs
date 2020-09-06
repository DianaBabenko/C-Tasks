using System;

namespace ConsoleApp1
{
    public class Task2
    {
        public void Main2()
        {
            Console.Write("Введіть значення 'x': ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть значення 'y': ");
            double y = Convert.ToInt32(Console.ReadLine());
            
            double result = (Math.Abs(x) - Math.Abs(y)) / (1 + Math.Abs(x * y));
            Console.WriteLine("Результат:"+ result);
        }
    }
}