using MariaSchillstrom_Assigment2.Interfaces;

namespace MariaSchillstrom_Assigment2.Models
{
    public class CarImpl : IVehicle// 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public int Doors { get; set; } 

        private bool isEngineOn; // Variabel för att hålla reda på motorstatus

        // Konstruktor
        public CarImpl(string brand, string model, int year, double mileage, int doors)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            Doors = doors;
            isEngineOn = false; // Motor är avstängd till en början
        }

        // Implementerar IsEngineOn som en egenskap
        public bool IsEngineOn => isEngineOn;// true or false

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

        
        public override string ToString()// Skriver ut information om bilen i textsträng
        {
            return $"Car: {Brand} {Model}, Year: {Year}, Mileage: {Mileage}, Doors: {Doors}, Engine On: {IsEngineOn}";
        }

        
        void IVehicle.startEngine()
        {
            StartEngine();
        }
    }
}





