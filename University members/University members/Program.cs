public class Person
{
    public string Name;
    public string Email;

    public Person(string name, string email)
    {
        Name = name;
        Email = email;
        Console.WriteLine($"[Constructor] Person: {Name}");
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Name: {Name}, Email: {Email}");
    }
}

public class Student : Person
{
    public string StudentId;
    public double GPA;

    public Student(string name, string email, string studentId, double gpa)
        : base(name, email)
    {
        StudentId = studentId;
        GPA = gpa;
        Console.WriteLine($"[Constructor] Student: {StudentId}");
    }

    public void DisplayStudentInfo()
    {
        DisplayBasicInfo();
        Console.WriteLine($"Student ID: {StudentId}, GPA: {GPA}");
    }
}

public class Employee : Person
{
    public string EmployeeId;
    public decimal Salary;

    public Employee(string name, string email, string employeeId, decimal salary)
        : base(name, email)
    {
        EmployeeId = employeeId;
        Salary = salary;
        Console.WriteLine($"[Constructor] Employee: {EmployeeId}");
    }
}

public class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, string email, string employeeId, decimal salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        CourseName = courseName;
        Console.WriteLine($"[Constructor] Teacher: Teaching {CourseName}");
    }

    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching {CourseName}.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Creating Student Object ---");
        Student student = new Student("Ali", "ali@univ.edu", "S12345", 3.8);

        Console.WriteLine("\n--- Creating Teacher Object ---");
        Teacher teacher = new Teacher("Dr. Sarah", "sarah@univ.edu", "E9876", 5000, "Computer Science");

        Console.WriteLine("\n--- Testing Methods ---");
        student.DisplayBasicInfo();
        student.DisplayStudentInfo();

        teacher.DisplayBasicInfo();
        teacher.Teach();
    }
}