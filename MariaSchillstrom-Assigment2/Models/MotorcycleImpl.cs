using MariaSchillstrom_Assigment2.Interfaces;

namespace MariaSchillstrom_Assigment2.Models
{
    public class MotorcycleImpl : IVehicle
    {
        public MotorcycleImpl(string brand, string model, int year, double mileage, string engineType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            EngineType = engineType; // Behåll denna om engineType behövs
            EngineOn = false; // Initialisera motorn som av
        }

        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public double Mileage { get; private set; }
        public bool EngineOn { get; private set; }
        public string EngineType { get; private set; } // Behåll denna om engineType behövs

        public bool IsEngineOn => EngineOn;

        public void StartEngine()
        {
            EngineOn = true;
        }

        public void StopEngine()
        {
            EngineOn = false;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - Mileage: {Mileage} - Engine Type: {EngineType}";
        }
    }
}

