using System;

namespace UniversityMembers
{
    // Base Class: Person
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
            Console.WriteLine("Person constructor executed");
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    // Derived Class: Student (inherits directly from Person)
    class Student : Person
    {
        public int StudentId { get; set; }
        public double GPA { get; set; }

        public Student(string name, string email, int studentId, double gpa)
            : base(name, email)
        {
            StudentId = studentId;
            GPA = gpa;
            Console.WriteLine("Student constructor executed");
        }
    }

    // Derived Class: Employee (inherits directly from Person)
    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, int employeeId, double salary)
            : base(name, email)
        {
            EmployeeId = employeeId;
            Salary = salary;
            Console.WriteLine("Employee constructor executed");
        }
    }

    // Derived Class: Teacher (inherits from Employee -> Multilevel Inheritance)
    class Teacher : Employee
    {
        public string CourseName { get; set; }

        public Teacher(string name, string email, int employeeId, double salary, string courseName)
            : base(name, email, employeeId, salary)
        {
            CourseName = courseName;
            Console.WriteLine("Teacher constructor executed");
        }

        public void Teach()
        {
            Console.WriteLine($"Dr. {Name} is teaching: {CourseName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Creating Student Object ===");
            // Create one object from Student
            Student student = new Student("Sara", "sara@uni.com", 101, 3.8);

            // Call inherited method and access specialized fields
            student.DisplayBasicInfo();
            Console.WriteLine($"Student ID: {student.StudentId}, GPA: {student.GPA}");
            Console.WriteLine();

            Console.WriteLine("=== Creating Teacher Object ===");
            // Create one object from Teacher
            Teacher teacher = new Teacher("Ahmed", "ahmed@uni.com", 201, 8500, "Object Oriented Programming");

            // Call inherited methods and specialized method
            teacher.DisplayBasicInfo(); // Inherited from Person
            Console.WriteLine($"Employee ID: {teacher.EmployeeId}, Salary: {teacher.Salary}"); // Inherited from Employee
            teacher.Teach(); // Specialized method in Teacher
        }
    }
}