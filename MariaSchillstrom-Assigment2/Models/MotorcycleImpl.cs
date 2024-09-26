using MariaSchillstrom_Assigment2.Interfaces;

namespace MariaSchillstrom_Assigment2.Models
{
    public class MotorcycleImpl : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string EngineType { get; set; } // Motortyp

        private bool isEngineOn; // Variabel för att hålla reda på motorstatus

        // Konstruktor
        public MotorcycleImpl(string brand, string model, int year, double mileage, string engineType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            EngineType = engineType;
            isEngineOn = false; // Motor är avstängd initialt
        }

        // Implementerar IsEngineOn som en property
        public bool IsEngineOn => isEngineOn;

        // Metod för att starta motorn
        public void StartEngine()
        {
            isEngineOn = true; // Motor är på
        }

        // Metod för att stänga av motorn
        public void StopEngine()
        {
            isEngineOn = false; // Motor är av
        }

        // Överskriven ToString-metod
        public override string ToString()
        {
            return $"Motorcycle: {Brand} {Model}, Year: {Year}, Mileage: {Mileage}, EngineType: {EngineType}";
        }
    }
}
