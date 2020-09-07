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
            this.Numerator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(this.Numerator);
        }

        public void SetDenominator()
        {
            Console.Write("Введіть знаменник: ");
            this.Denominator = Convert.ToInt32(Console.ReadLine()); 
        }

        public double GetNumerator()
        {
            Console.WriteLine(this.Numerator);
            return this.Numerator;
        }

        public double GetDenominator()
        {
            Console.WriteLine(this.Numerator);
            return this.Denominator;
        }

        public double NumbersSum()
        {
            Console.WriteLine(this.Numerator + this.Denominator);
            return this.Numerator + this.Denominator;
        }

        public double MultiplicationNumbers()
        {
            Console.WriteLine(this.Numerator * this.Denominator);
            return this.Numerator * this.Denominator;
        }

        public double NumbersDifference()
        {
            Console.WriteLine(this.Numerator - this.Denominator);
            return this.Numerator - this.Denominator;
        }

        public double DivisionNumbers()
        {
            Console.WriteLine(this.Numerator / this.Denominator);
            return this.Numerator / this.Denominator;
        }
    }
}