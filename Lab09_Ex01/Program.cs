   using System;

class Program
{
    static void Main()
    {
        Person.name = "Pao"; // Assign a name
        Console.WriteLine(Person.GetName()); // Call GetName to print the message
    }
}

static class Person
{
    public static string? name; // Declare name with nullable string type
    public static string GetName()
    {
        return $"Hello from {name}";
    }
}
