namespace UniversityMembers2
{
    // 1. Base Class: Person contains Name and a virtual DisplayInfo()
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    // 2. Student adds StudentId and overrides DisplayInfo()
    class Student : Person
    {
        public int StudentId { get; set; }

        public Student(string name, int studentId) : base(name)
        {
            StudentId = studentId;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Student] Name: {Name}, Student ID: {StudentId}");
        }
    }

    // 3. Employee adds Salary and overrides DisplayInfo()
    class Employee : Person
    {
        public double Salary { get; set; }

        public Employee(string name, double salary) : base(name)
        {
            Salary = salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Employee] Name: {Name}, Salary: {Salary}");
        }
    }

    // 4. Teacher adds CourseName and overrides DisplayInfo()
    class Teacher : Person
    {
        public string CourseName { get; set; }

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
        // Add one method that accepts Person and calls DisplayInfo()
        static void ShowPersonDetails(Person person)
        {
            person.DisplayInfo();
        }

        static void Main(string[] args)
        {
            // Store at least one object of each type in List<Person>
            List<Person> members = new List<Person>
            {
                new Person("Generic Person"),
                new Student("Sara", 101),
                new Employee("John", 5000),
                new Teacher("Dr. Ahmed", "Object Oriented Programming")
            };

            Console.WriteLine("=== Iterating through List<Person> ===");
            // Use one foreach loop to call DisplayInfo() and print GetType() inside the loop
            foreach (Person member in members)
            {
                Console.WriteLine($"Runtime Type: {member.GetType().Name}");
                member.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("=== Testing Standalone Method Accepting Person ===");
            // Call the method that accepts a Person object
            ShowPersonDetails(new Teacher("Dr. Mona", "Data Structures"));
        }
    }
}
