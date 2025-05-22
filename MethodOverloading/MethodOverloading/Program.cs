using System;

namespace Overload
{
    
    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public double Add(double a, double b) => a + b;

        public string Add(string a, string b) => a + b;
    }

    // 2. Class Hierarchy: Animal → Dog, Cat
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    // 5. Tests and Execution
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("== Overloaded Method Tests ==");

            var calc = new Calculator();
            Console.WriteLine("Add(int, int): " + calc.Add(2, 3));               // 5
            Console.WriteLine("Add(double, double): " + calc.Add(2.5, 3.1));     // 5.6
            Console.WriteLine("Add(string, string): " + calc.Add("Hello ", "World")); // Hello World

            Console.WriteLine("\n== Overridden Method Tests ==");

            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine("Calling MakeSound on Dog:");
            dog.MakeSound();  // Dog barks.

            Console.WriteLine("Calling MakeSound on Cat:");
            cat.MakeSound();  // Cat meows.

            Console.WriteLine("\n== Test Cases ==");

            Console.WriteLine(calc.Add(1, 2) == 3 ? "Test 1 Passed" : "Test 1 Failed");
            Console.WriteLine(Math.Abs(calc.Add(1.1, 2.2) - 3.3) < 0.001 ? "Test 2 Passed" : "Test 2 Failed");
            Console.WriteLine(calc.Add("A", "B") == "AB" ? "Test 3 Passed" : "Test 3 Failed");

            Console.WriteLine("Expected: Dog barks. | Actual:");
            dog.MakeSound();

            Console.WriteLine("Expected: Cat meows. | Actual:");
            cat.MakeSound();
        }
    }
}