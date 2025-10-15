using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object and assign values
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Create the second Employee object and assign values
            Employee employee2 = new Employee
            {
                Id = 102,
                FirstName = "Bob",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded '==' operator
            bool areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual}");

            // Compare using the '!=' operator
            bool areNotEqual = employee1 != employee2;

            // Display the result of the inequality comparison
            Console.WriteLine($"Are employee1 and employee2 not equal? {areNotEqual}");

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }
}