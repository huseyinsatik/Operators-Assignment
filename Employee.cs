using System;

// Employee class that represents an employee in the system
public class Employee
{
    // Properties to store employee information
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the equality (==) operator
    // This operator compares two Employee objects based on their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both objects are null, return true
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;

        // If one object is null, return false
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare the Id properties of both employees
        return emp1.Id == emp2.Id;
    }

    // Overloading the inequality (!=) operator
    // This operator must be overloaded when == is overloaded
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Return the opposite of the == operator
        return !(emp1 == emp2);
    }

    // Override Equals method to maintain consistency with == operator
    public override bool Equals(object obj)
    {
        if (obj is Employee employee)
            return this == employee;
        return false;
    }

    // Override GetHashCode to maintain consistency with Equals
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
} 