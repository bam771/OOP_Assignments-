
using System;
using System.Collections.Generic;

public class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

public class Student : Person
{
    public string StudentId;

    public Student(string name, string studentId) : base(name)
    {
        StudentId = studentId;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {Name}, Student ID: {StudentId}");
    }
}

public class Employee : Person
{
    public decimal Salary;

    public Employee(string name, decimal salary) : base(name)
    {
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}, Salary: {Salary}");
    }
}

public class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, decimal salary, string courseName) : base(name, salary)
    {
        CourseName = courseName;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher Name: {Name}, Salary: {Salary}, Course: {CourseName}");
    }
}

class Program
{
    public static void ShowPersonInfo(Person p)
    {
        p.DisplayInfo();
    }

    static void Main()
    {
        List<Person> people = new List<Person>();

        people.Add(new Person("Abdullah"));
        people.Add(new Student("Ali", "S1001"));
        people.Add(new Employee("Salem", 4500));
        people.Add(new Teacher("Dr. Ahmed", 8000, "Mathematics"));

        foreach (Person person in people)
        {
            Console.WriteLine($"Runtime Type: {person.GetType()}");
            person.DisplayInfo();
            Console.WriteLine();
        }

        Console.WriteLine("--- Testing Method That Accepts Person ---");
        Student testStudent = new Student("Omar", "S2002");
        ShowPersonInfo(testStudent);
    }
}

