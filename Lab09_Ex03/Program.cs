using System;

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.name = "Pao";
        Console.WriteLine(person.GetName());

        Student student = new Student();
        student.name = "Thanyathep";
        Console.WriteLine(student.GetName());
    }
}

class Person
{
    public string? name;

    public string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{
}

