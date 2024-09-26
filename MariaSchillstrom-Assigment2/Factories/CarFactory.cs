using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;

namespace MariaSchillstrom_Assigment2.Factories 
{ 
    public class CarFactory : IVehicleFactory
    {
        public CarImpl CreateCar(string brand, string model, int year, double mileage, int doors)
        {
            return new CarImpl(brand, model, year, mileage, doors);
        }


        public IVehicle CreateVehicle(string brand, string model, int year, double mileage)
        {
            int doors = 0;
            return CreateCar(brand, model, year, mileage, doors); // Antag att 4 dörrar som standard
        }

    }
}




