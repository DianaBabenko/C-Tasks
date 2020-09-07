using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task23 task1 = new Task23();
            task1.SetNumerator();
            task1.SetDenominator();
            task1.NumbersDifference();
        }
    }
}