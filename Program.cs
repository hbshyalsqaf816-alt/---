using System;
using System.Collections.Generic;

/*class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Person Name: {Name}");
    }
}

class Student : Person
{
    public int StudentId { get; set; }

    public Student(string name, int studentId) : base(name)
    {
        StudentId = studentId;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, ID: {StudentId}");
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string name, double salary) : base(name)
    {
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name}, Salary: ${Salary}");
    }
}

class Teacher : Person
{
    public string CourseName { get; set; }

    public Teacher(string name, string courseName) : base(name)
    {
        CourseName = courseName;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher: {Name}, Course: {CourseName}");
    }
}

class Program
{
    public static void ProcessPerson(Person person)
    {
        person.DisplayInfo();
    }

    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person("Ahmed"),
            new Student("Sara", 101),
            new Employee("Khalid", 5000),
            new Teacher("Dr. Omar", "C# Programming")
        };

        Console.WriteLine("--- Displaying Info with GetType() ---");
        foreach (var p in people)
        {
            Console.WriteLine($"Runtime Type: {p.GetType().Name}");
            p.DisplayInfo();
            Console.WriteLine("----------------");
        }

        Console.WriteLine("\n--- Testing Single Method Parameter ---");
        ProcessPerson(new Student("Lina", 102));
    }
}*/






using System;
using System.Collections.Generic;

/*class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5.0),
            new Rectangle(4.0, 6.0)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Type: {shape.GetType().Name}, Area: {shape.CalculateArea():F2}");
        }
    }
}*/








using System;

/*class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine($"{Year} {Brand} is starting...");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, int year, int numberOfDoors) : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }
}

class Bus : Vehicle
{
    public int Capacity { get; set; }

    public Bus(string brand, int year, int capacity) : base(brand, year)
    {
        Capacity = capacity;
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year)
    {
        HasSidecar = hasSidecar;
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", 2022, 4);
        Bus myBus = new Bus("Volvo", 2020, 50);
        Motorcycle myBike = new Motorcycle("Harley", 2021, false);

        myCar.Start();
        myBus.Start();
        myBike.Start();
    }
}*/




using System;

/*class Person
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Person(string name, string email)
    {
        Name = name;
        Email = email;
        Console.WriteLine("-> Person constructor executed.");
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Name: {Name}, Email: {Email}");
    }
}

class Student : Person
{
    public int StudentId { get; set; }
    public double GPA { get; set; }

    public Student(string name, string email, int studentId, double gpa) : base(name, email)
    {
        StudentId = studentId;
        GPA = gpa;
        Console.WriteLine("-> Student constructor executed.");
    }
}

class Employee : Person
{
    public int EmployeeId { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string email, int employeeId, double salary) : base(name, email)
    {
        EmployeeId = employeeId;
        Salary = salary;
        Console.WriteLine("-> Employee constructor executed.");
    }
}

class Teacher : Employee
{
    public string CourseName { get; set; }

    public Teacher(string name, string email, int employeeId, double salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        CourseName = courseName;
        Console.WriteLine("-> Teacher constructor executed.");
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
        Student student = new Student("Ali", "ali@uni.edu", 44101, 3.8);
        student.DisplayBasicInfo();

        Console.WriteLine("\n--- Creating Teacher Object ---");
        Teacher teacher = new Teacher("Dr. Fahad", "fahad@uni.edu", 9001, 12000, "AI Basics");
        teacher.DisplayBasicInfo();
        teacher.Teach();
    }
}*/   