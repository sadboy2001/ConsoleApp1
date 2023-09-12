using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Tom", "Microsoft"); // Создание объекта Employee
            Person person = employee;   // преобразование от Employee к Person
            Person bob = new Client("Bob", "ContosoBank");// Создание объекта Person с преобразованием в Client
            Console.WriteLine(((Client)bob).Bank); // дополнительное преобразование от Person к Client для вызова переменной Bank



            object obj = new Employee("Bill", "Microsoft");
            // ((Person)obj).Print();
            string company = ((Employee)obj).Company;
            // Console.WriteLine(company);



            // Console.WriteLine(person.Name);
            // Console.WriteLine(bob);
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int age { get; set; }
        public Person(string name) // Конструктор Person
        {
            Name = name;
        }
        public Person(string name, int age) // Перегрузка конструктора Person
        {
            Name = name;
            this.age = age;
        }
        public void Print()
        {
            Console.WriteLine($"Person {Name}");
        }
    }

    class Employee : Person // Наследование от класса Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name) // Наследование конструктора
        {
            Company = company;
        }
        public Employee(string name, string company, int age) : base(name, age) // Наследование перегруженного конструктора
        {
            Company = company;
        }
        
    }

    class Client : Person // Наследование от класса Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name) // Наследование конструктора
        {
            Bank = bank;
        }
    }
}