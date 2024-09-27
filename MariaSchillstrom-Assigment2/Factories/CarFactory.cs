using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;

namespace MariaSchillstrom_Assigment2.Factories 
{ 
    public class CarFactory : IVehicleFactory
    {
        public CarImpl CreateCar(string brand, string model, int year, double mileage, int doors)// Skapar en bils egenskaper baserat på information från IVehicle samt Icar
        {
            return new CarImpl(brand, model, year, mileage, doors);// Returnerar en ny bil med egenskaper från IVehicle samt ICar
        }


        public IVehicle CreateVehicle(string brand, string model, int year, double mileage)//standardegenskaper för alla vehicles 
        {
            int doors = 0;
            return CreateCar(brand, model, year, mileage, doors); //returner en bil med alla egenskaperna ink doors från ICar
        }

    }
}




