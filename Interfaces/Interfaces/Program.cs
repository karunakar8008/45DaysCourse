using System;

namespace PracticalTask
{
    // Step 1: Interface IVehicle
    public interface IVehicle
    {
        void Start();
        void Stop();
    }

    // Step 2: Car class implements IVehicle
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped.");
        }
    }

    // Step 2: Bike class implements IVehicle
    public class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike started.");
        }

        public void Stop()
        {
            Console.WriteLine("Bike stopped.");
        }
    }

    // Step 3: Abstract class Shape
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    // Step 4: Circle inherits from Shape
    public class Circle : Shape
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

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Step 4: Rectangle inherits from Shape
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }

    // Main Execution
    class Program
    {
        static void Main(string[] args)
        {
            // Vehicle demo
            IVehicle car = new Car();
            IVehicle bike = new Bike();

            car.Start();
            car.Stop();
            bike.Start();
            bike.Stop();

            Console.WriteLine();

            // Shape demo
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");
            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter():F2}");

            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea():F2}");
            Console.WriteLine($"Rectangle Perimeter: {rectangle.CalculatePerimeter():F2}");
        }
    }
}