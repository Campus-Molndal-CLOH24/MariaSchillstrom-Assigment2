using MariaSchillstrom_Assignment_2.InterFaces;
using System;

namespace MariaSchillstrom_Assignment_2.Models
{
    public class CarImpl : ICar
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }

        // Mileage kommer från IVehicle
        public double Mileage { get; set; }

        // Implementera Doors från ICar
        private int doors;

        public int Doors
        {
            get => doors;
            set
            {
                if (value >= 2 && value <= 5)
                {
                    doors = value;
                }
                else
                {
                    Console.WriteLine("Antalet dörrar måste vara mellan 2 och 5.");
                }
            }
        }

        private bool engineOn = false;

        public CarImpl(string brand, string model, int year, double mileage, int doors)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            Doors = doors;  // Sätt Doors från ICar
        }

        public CarImpl() { }

        // Implementera metoder från IDrivable
        public bool IsEngineOn()
        {
            return engineOn;
        }

        public void StartEngine()
        {
            if (!engineOn)
            {
                engineOn = true;
                Console.WriteLine("The engine started!");
            }
        }

        public void StopEngine()
        {
            if (engineOn)
            {
                engineOn = false;
                Console.WriteLine("The engine stopped.");
            }
        }

        public string Drive()
        {
            if (engineOn)
            {
                Console.WriteLine("The car is driving.");
                return "The car is driving.";
            }
            else
            {
                Console.WriteLine("The engine is not on.");
                return "The engine is not on.";
            }
        }

        public override string ToString()
        {
            return $"{Brand} {Model} {Year}";
        }
    }
}
