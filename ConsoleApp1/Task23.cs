using System;

namespace ConsoleApp1
{
    public class Task23
    {
        private double Numerator { get; set; }
        private double Denominator { get; set; }
        
        public void SetNumerator()
        {
            Console.Write("Введіть чисельник: ");
            Numerator = Convert.ToDouble(Console.ReadLine());
        }

        public void SetDenominator()
        {
            Console.Write("Введіть знаменник: ");
            Denominator = Convert.ToInt32(Console.ReadLine()); 
        }

        public double GetNumerator()
        {
            Console.WriteLine(Numerator);
            return Numerator;
        }

        public double GetDenominator()
        {
            Console.WriteLine(Numerator);
            return Denominator;
        }

        public double NumbersSum()
        {
            Console.WriteLine(Numerator + Denominator);
            return Numerator + Denominator;
        }

        public double MultiplicationNumbers()
        {
            Console.WriteLine(Numerator * Denominator);
            return Numerator * Denominator;
        }

        public double NumbersDifference()
        {
            Console.WriteLine(Numerator - Denominator);
            return Numerator - Denominator;
        }

        public double DivisionNumbers()
        {
            Console.WriteLine(Numerator / Denominator);
            return Numerator / Denominator;
        }
    }
}