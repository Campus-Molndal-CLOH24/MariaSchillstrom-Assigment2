﻿using MariaSchillstrom_Assigment2.Models;
using MariaSchillstrom_Assigment2.Factories;
using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assignment_2.InterFaces;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;

List<IVehicle> vehicles = new List<IVehicle>();

vehicles.Add(new CarImpl("Volvo", "V70", 2005, 200000, 5));
vehicles.Add(new MotorcycleImpl("Yamaha", "FZ1", 2006, 15000, "Inline-4"));
vehicles.Add(new CarImpl("Volvo", "P1800", 1974, 200000, 4));
vehicles.Add(new MotorcycleImpl("Yamaha", "R18", 2006, 185000, "Inline-6"));
vehicles.Add(new CarImpl("Ford", "Mustang", 1985, 15800, 5));
vehicles.Add(new MotorcycleImpl("Kawasaki", "Ninja", 2022, 250, "Inline-5"));

foreach (var vehicle in vehicles)
{
    Console.WriteLine(vehicle.ToString());

    if (vehicle is ICar)
    {
        Console.WriteLine("This vehicle has doors");
    }
    if (vehicle is IMotorCycle)
    {
        Console.WriteLine("This vehicle has cylinders");
    }
}