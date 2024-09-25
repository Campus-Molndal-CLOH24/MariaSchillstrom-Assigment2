using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;
using System.Collections;

namespace MariaSchillstrom_Assigment2.Interfaces
{
    public interface IVehicleFactory
    {        
        
        IVehicle CreateVehicle(string brand, string model, int year, int mileage, string engineType);
    }
}

