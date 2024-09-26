using MariaSchillstrom_Assigment2.Models;

namespace MariaSchillstrom_Assigment2.Interfaces
{
    
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string brand, string model, int year, double mileage);
        
    }
}



