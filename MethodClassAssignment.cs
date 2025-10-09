using System;

namespace FriendlyMathApp
{
    // This class contains a method that performs a simple math operation
    class Calculator
    {
        // This method takes two integers as input
        // It multiplies the first number by 2 and prints both the result and the second number
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Multiply the first number by 2
            int result = firstNumber * 2;

            // Display the result of the math operation
            Console.WriteLine($"The result of multiplying {firstNumber} by 2 is: {result}");

            // Display the second number as-is
            Console.WriteLine($"The second number you provided is: {secondNumber}");
        }
    }

    class Program
    {
        // This is the entry point of the console application
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator myCalculator = new Calculator();

            // Call the method using positional arguments
            // This will multiply 5 by 2 and display 10, then show the second number (3)
            myCalculator.DoMath(5, 3);

            // Call the method using named arguments
            // This improves readability and makes it clear which value is which
            myCalculator.DoMath(firstNumber: 8, secondNumber: 4);

            // Pause the console so the user can see the output before the window closes
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}