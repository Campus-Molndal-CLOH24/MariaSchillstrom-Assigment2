using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;
using System.Collections;

namespace MariaSchillstrom_Assigment2.Interfaces
{
    public interface IVehicleFactory
    {
        CarImpl CreateCar(string brand, string model, int year, int mileage, int doors);
        IVehicle CreateVehicle(string brand, string model, int year, int mileage, string engineType);
    }
}

    
