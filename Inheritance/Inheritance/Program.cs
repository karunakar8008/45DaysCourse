using System;

namespace Inheritance
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }



    }

    class Student : Person
    {
        public char Grade;

        public Student(string name, int age, char grade) : base(name, age)
        {
            Grade = grade;
        }

        public void DisplayInfo()
        {
            System.Console.WriteLine($"The person name is {Name}, age is {Age} and Grade is {Grade}");
        }
    }

    class Employee : Person
    {
        public int Salary;

        public Employee(string name, int age, int salary) : base(name, age)
        {
            Salary = salary;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"The person name is {Name}, age is {Age} and Grade is {Salary}");
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student("Karunakar", 21, 'A');
            Employee e = new Employee("Karunakar", 21, 30000);
            s.DisplayInfo();
            e.DisplayInfo();
        }
    }


}