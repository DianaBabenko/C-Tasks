using System;

namespace ConsoleApp1
{
    public class Task15
    {
        public void Main15()
        {
            Console.Write("Введіть значення гіпотенузи: ");
            int hypotenuse = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введіть значення першого катету: ");
            int catetFirst = Convert.ToInt32(Console.ReadLine());

            double catetSecond = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(catetFirst, 2));
            double perimeter = hypotenuse + catetFirst + catetSecond;
            double square = (catetFirst + catetSecond) / 2;

            double r = square / perimeter;

            Console.WriteLine("Другий катет :" + catetSecond);
            Console.WriteLine("Радіус вписаної окружності :" + r);
        }
    }
}