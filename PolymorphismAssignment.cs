using System;

// Define the IQuittable interface with a Quit method
public interface IQuittable
{
    void Quit(); // Method signature for quitting
}

// Define the Employee class that implements IQuittable
public class Employee : IQuittable
{
    // Properties for the Employee class
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor to initialize Employee object
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Implementation of the Quit method from IQuittable interface
    public void Quit()
    {
        // Display a message indicating the employee has quit
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee emp = new Employee("John", "Doe");

        // Use polymorphism: assign Employee object to IQuittable interface type
        IQuittable quittableEmp = emp;

        // Call the Quit method using the IQuittable reference
        quittableEmp.Quit();

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}