using System;

namespace EmployeeComparisonApp
{
    // Define the Employee class
    public class Employee
    {
        // Property to store the employee's unique identifier
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Overload the '==' operator to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, they are equal
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either is null, they are not equal
            if (emp1 is null || emp2 is null)
                return false;

            // Compare by Id
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator as required when overloading '=='
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to match the behavior of '=='
        public override bool Equals(object obj)
        {
            return this == obj as Employee;
        }

        // Override GetHashCode to ensure consistency with Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}