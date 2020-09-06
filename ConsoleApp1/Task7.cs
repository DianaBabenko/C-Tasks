using System;

namespace ConsoleApp1
{
    public class Task7
    {
        public void Main7()
        {
            Console.Write("Введіть значення першого об'єму: ");
            var v1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть значення другого об'єму: ");
            var v2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введіть значення першого часу: ");
            var t1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть значення другого часу: ");
            var t2 = Convert.ToInt32(Console.ReadLine());

            var volume = v1 + v2;
            var temperature = (v1 * t1 + v2 * t2) / (v1 + v2);

            Console.WriteLine("Об'єм: " + volume);
            Console.WriteLine("Температура: " + temperature);
        }
    }
}