using System;

namespace ConsoleApp1
{
    public class Task9
    {
        public void Main9()
        {
            Console.Write("Введіть значення R1: ");
            double r1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть значення R2: ");
            double r2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введіть значення R3: ");
            double r3 = Convert.ToInt32(Console.ReadLine());

            double resistanceConnection = (1 / r1) + (1 / r2) + (1 / r3);

            Console.WriteLine("Супротив з'єднання: " + resistanceConnection);
        }
    }
}