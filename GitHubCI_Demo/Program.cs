using System;

namespace GitHubCI_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculator Application ===");
            
            Calculator calc = new Calculator();
            double num1 = 20;
            double num2 = 5;

            Console.WriteLine($"Number 1: {num1}, Number 2: {num2}");
            Console.WriteLine($"Addition: {num1} + {num2} = {calc.Addition(num1, num2)}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {calc.Subtraction(num1, num2)}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {calc.Multiplication(num1, num2)}");
            Console.WriteLine($"Division: {num1} / {num2} = {calc.Division(num1, num2)}");

            Console.WriteLine("\nCalculator execution verified successfully.");
        }
    }
}
