using System;

namespace Practice_4
{
    class Practice_4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number 1:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number 2:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Addition: {num1 + num2}");
                Console.WriteLine($"Subtraction: {num1 - num2}");
                Console.WriteLine($"Multiplication: {num1 * num2}");
                Console.WriteLine($"Division: {(Double)num1 / (Double) num2}");
                Console.WriteLine($"Remainder: {num1 % num2}");
                Console.WriteLine($"Average: {(num1 + num2) / 2}");
                Console.WriteLine($"num1 Squared: {Math.Pow(num1, 2)}");
                Console.WriteLine($"num2 Square Rooted: {Math.Sqrt(num2)}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can not divide by Zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error has occurred: {ex.GetType()}:{ex.Message}");
            }
        }
    }
}