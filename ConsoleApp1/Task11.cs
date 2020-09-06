using System;

namespace ConsoleApp1
{
    public class Task11
    {
        public void Main11()
        {
            Console.Write("Введіть значення x: ");
            double x = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введіть значення y: ");
            double y = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введіть значення z: ");
            double z = Convert.ToInt32(Console.ReadLine());

            double a1 = (Math.Pow(Math.Abs(x - 1), 0.5) - Math.Pow(Math.Abs(y), (1 / 3.0)) 
                          / (1 + Math.Pow(x, 2) / 2) + Math.Pow(y, 2) / 4);
            double b1 = x * (Math.Atan(z) + (Math.Exp((x + 3) * -1)));

            Console.WriteLine("A = : " + a1);
            Console.WriteLine("B= : " + b1);
        }
    }
}