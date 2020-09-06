using System;

namespace ConsoleApp1
{
    public class Task13
    {
        public void Main13()
        {
            Console.Write("Введіть значення довжини: ");
            int length = Convert.ToInt32(Console.ReadLine());
            
            double g = 9.8;

            double period = 2 * Math.PI * (Math.Sqrt(length / g));

            Console.WriteLine("Період : " + period);
        }
    }
}