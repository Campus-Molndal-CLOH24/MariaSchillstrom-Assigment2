using MariaSchillstrom_Assigment2.Models;
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
    if (vehicle is CarImpl car)
    {
        //ville få tom rad mellan varje fordon så valde denna lösning
        Console.WriteLine($"Car: {car.Brand} {car.Model}, Year: {car.Year}, Mileage: {car.Mileage}, Doors: {car.Doors}, Engine On: {car.IsEngineOn}");
        Console.WriteLine("This vehicle has doors");
        car.StartEngine();
        Console.WriteLine("Engine started for CarImpl.");
        car.StopEngine();
        Console.WriteLine("Engine stopped for CarImpl.");
    }
    else if (vehicle is MotorcycleImpl motorcycle)
    {
        //ville få tom rad mellan varje fordon så valde denna lösning
        Console.WriteLine($"Motorcycle: {motorcycle.Brand} {motorcycle.Model}, Year: {motorcycle.Year}, Mileage: {motorcycle.Mileage}, EngineType: {motorcycle.EngineType}");
        Console.WriteLine("This vehicle has cylinders");
        motorcycle.StartEngine();
        Console.WriteLine($"Engine started for {vehicle.Brand} {vehicle.Model}.");
        motorcycle.StopEngine();
        Console.WriteLine($"Engine stopped for {vehicle.Brand} {vehicle.Model}.");
    }

    
    Console.WriteLine();//ger en tom rad mellan varje fordon
}
