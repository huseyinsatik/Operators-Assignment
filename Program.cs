using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two Employee objects with different properties
        Employee employee1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        Employee employee2 = new Employee
        {
            Id = 1,
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Create a third employee with a different Id
        Employee employee3 = new Employee
        {
            Id = 2,
            FirstName = "Alice",
            LastName = "Johnson"
        };

        // Compare employees using the overloaded == operator
        Console.WriteLine("Comparing employees:");
        Console.WriteLine($"employee1 == employee2: {employee1 == employee2}"); // Should return true (same Id)
        Console.WriteLine($"employee1 == employee3: {employee1 == employee3}"); // Should return false (different Id)
        Console.WriteLine($"employee1 != employee3: {employee1 != employee3}"); // Should return true (different Id)

        // Wait for user input before closing
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
} 