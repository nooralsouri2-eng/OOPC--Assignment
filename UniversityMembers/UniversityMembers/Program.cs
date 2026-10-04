using System;
using System.Collections.Generic;

namespace UniversityMembers
{
    // 1. Person الكلاس الأساسي
    class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }

        // virtual DisplayInfo()
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    // 2. Student يرث من Person
    class Student : Person
    {
        public int StudentId;

        public Student(string name, int studentId) : base(name)
        {
            StudentId = studentId;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Student] Name: {Name}, Student ID: {StudentId}");
        }
    }

    // 3. Employee يرث من Person
    class Employee : Person
    {
        public double Salary;

        public Employee(string name, double salary) : base(name)
        {
            Salary = salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Employee] Name: {Name}, Salary: {Salary}");
        }
    }

    // 4. Teacher يرث من Person
    class Teacher : Person
    {
        public string CourseName;

        public Teacher(string name, string courseName) : base(name)
        {
            CourseName = courseName;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Teacher] Name: {Name}, Course: {CourseName}");
        }
    }

    class Program
    {
        // دالة تقبل Person وتستدعي DisplayInfo
        static void PrintPersonInfo(Person person)
        {
            person.DisplayInfo();
        }

        static void Main()
        {
            // إنشاء List<Person> وتخزين كائن من كل نوع
            List<Person> members = new List<Person>
            {
                new Person("Generic Person"),
                new Student("Sara", 101),
                new Employee("Ali", 5000),
                new Teacher("Dr. Ahmed", "OOP")
            };

            Console.WriteLine("--- Loop through List<Person> ---");
            // استخدام foreach وطباعة GetType()
            foreach (Person member in members)
            {
                Console.WriteLine($"Runtime Type: {member.GetType().Name}");
                member.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("--- Calling method accepting Person ---");
            // استدعاء الميثود التي تقبل Person
            PrintPersonInfo(new Teacher("Dr. Mona", "Data Structures"));
        }
    }
}