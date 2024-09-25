using System;
using MariaSchillstrom_Assigment2.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;

namespace MariaSchillstrom_Assigment2.Factories
{
    public interface CarFactory : IVehicleFactory
    {


        public CarImpl CreateCar(string brand, string model, int year, int mileage, int doors)
        {
            return new CarImpl(brand, model, year, mileage, doors);
        }
        public IVehicle CreateVehicle(string brand, string model, int year, int mileage)
        {
            return CreateCar(brand, model, year, mileage, 5);
        }
    }
}

