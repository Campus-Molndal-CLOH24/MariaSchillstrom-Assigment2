using MariaSchillstrom_Assigment2.Interfaces;

namespace MariaSchillstrom_Assigment2.Models
{
    public class CarImpl : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public int Doors { get; set; } // Antal dörrar

        private bool isEngineOn; // Variabel för att hålla reda på motorstatus

        // Konstruktor
        public CarImpl(string brand, string model, int year, double mileage, int doors)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            Doors = doors;
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
            return $"Car: {Brand} {Model}, Year: {Year}, Mileage: {Mileage}, Doors: {Doors}, Engine On: {IsEngineOn}";
        }

        // Explicit implementation of the startEngine() method from IVehicle
        void IVehicle.startEngine()
        {
            StartEngine();
        }
    }
}





