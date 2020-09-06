using System;

namespace ConsoleApp1
{
    public class Task1
    {
        public void Main1()
        {
            Console.Write("Введіть значення 'а': ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть значення 'b': ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("сума:" + (a + b));
            Console.WriteLine("різниця (a - b):" + (a - b));
            Console.WriteLine("добуток:" + (a * b));
        }
    }
}