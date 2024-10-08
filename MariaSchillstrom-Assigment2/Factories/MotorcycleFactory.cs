﻿using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;
using System.ComponentModel.DataAnnotations;

namespace MariaSchillstrom_Assigment2.Factories 
{
    public class MotorcycleFactory : IVehicleFactory
    {
        public MotorcycleImpl CreateMotorcycle(string brand, string model, int year, double mileage, string engineType)//Se CarFactory för kommentarer
        {
            return new MotorcycleImpl(brand, model, year, mileage, engineType);

        }

        public IVehicle CreateVehicle(string brand, string model, int year, double mileage)
        {

            string engineType = "";
            return CreateMotorcycle(brand, model, year, mileage, engineType);
        }
    }
}

    










