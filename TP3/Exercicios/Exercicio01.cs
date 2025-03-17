using System;

namespace TP3.Exercicios
{
    internal class Exercicio01
    {
       
        class Car
        {
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public void StartCar()
            {
                Console.WriteLine($"Starting {Model} ({Year}) - {Color}...");
            }

            public void StopCar()
            {
                Console.WriteLine($"Stopping {Model}...");
            }
        }

        public void Start()
        {
            Car myCar = new Car
            {
                Model = "Toyota Corolla",
                Year = 2022,
                Color = "Black"
            };

            myCar.StartCar();
            myCar.StopCar();
        }
    }
}
