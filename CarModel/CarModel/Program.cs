using System;
namespace CarModel
{
    
    public class CarModel
    {
        
        
        
        public string Brand { get; set; }
        public int Accelerate { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }

        public CarModel(string brand, int accelerate, string model, int year, int speed)
        {
            Brand = brand;
            Speed = speed;
            Accelerate = accelerate;
            Model = model;
            Year = year;
            Speed = speed;
        }
        public void Start()
        {
            System.Console.WriteLine($"{Brand} {Model} is starting");
        }

        public void Accelerat()
        {
            Speed += Accelerate;
            Console.WriteLine($"{Model} is accelerating. Current speed after accelerating: {Speed} km/h");
        }

        public void Brake()
        {
            if (Speed > 65)
            {
                Speed = 65;
            }
            Console.WriteLine($"{Model} is braking. Current speed: {Speed} km/h");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car Info: {Brand} {Model} {Year} ");
        }

        public static void Main(string[] args)
        {
            CarModel c1 = new CarModel("Toyota", 20, "Camry", 2022, 70);
            CarModel c2 = new CarModel("Honda", 10, "Odessy", 2024, 50);
            CarModel c3 = new CarModel("Tesla", 15, "Model Y", 2023, 65);

            c1.Start();
            c1.Accelerat();
            c1.Brake();
            c1.DisplayInfo();

            System.Console.WriteLine();

            c2.Start();
            c2.Accelerat();
            c2.Brake();
            c2.DisplayInfo();

            System.Console.WriteLine();

            c3.Start();
            c3.Accelerat();
            c3.Brake();
            c3.DisplayInfo();
        


        }
    }
}