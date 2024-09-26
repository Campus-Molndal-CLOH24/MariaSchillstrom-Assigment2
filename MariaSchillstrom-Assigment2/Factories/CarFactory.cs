using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Interfaces.MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;


public class CarFactory : IVehicleFactory
{
    public CarImpl CreateCar(string brand, string model, int year, double mileage, int doors)
    {
        return new CarImpl(brand, model, year, mileage, doors);
    }

    public MotorcycleImpl CreateMotorcycle(string brand, string model, int year, double mileage, string engineType)
    {
        return new MotorcycleImpl(brand, model, year, mileage, engineType);
    }

    public IVehicle CreateVehicle(string brand, string model, int year, double mileage)
    {
        return CreateCar(brand, model, year, mileage, 4); // Antag att 4 dörrar som standard
    }
}
