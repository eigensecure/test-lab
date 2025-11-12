using System;

namespace GitPracticeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Git Practice Lab!");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Calculator calc = new Calculator();
            Console.WriteLine($"Sum: {calc.Add(num1, num2)}");
            Console.WriteLine($"Product: {calc.Multiply(num1, num2)}");

            Console.WriteLine("\nEdit this file or add new methods to test commits and reverts.");
        }
    }
}
