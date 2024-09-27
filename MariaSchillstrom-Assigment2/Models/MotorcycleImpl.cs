using MariaSchillstrom_Assigment2.Interfaces;

namespace MariaSchillstrom_Assigment2.Models
{
    public class MotorcycleImpl : IVehicle 
    {
        // se kommentarer för CarImpl för mer detaljer
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string EngineType { get; set; } // Motortyp specifik för motorcyklar

        private bool isEngineOn; 

        
        public MotorcycleImpl(string brand, string model, int year, double mileage, string engineType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            EngineType = engineType;
            isEngineOn = false; 
        }

        
        public bool IsEngineOn => isEngineOn;//

        
        public void StartEngine()
        {
            isEngineOn = true; 
        }

        
        public void StopEngine()
        {
            isEngineOn = false; 
        }

        
        public override string ToString()
        {
            return $"Motorcycle: {Brand} {Model}, Year: {Year}, Mileage: {Mileage}, EngineType: {EngineType}";
        }

        public void startEngine()
        {
            throw new NotImplementedException();
        }
    }
}
