using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;


public class CarFactory : IVehicleFactory
{
    public CarImpl CreateCar(string brand, string model, int year, double mileage, int doors)
    {
        return new CarImpl(brand, model, year, mileage, doors);
    }


    public IVehicle CreateVehicle(string brand, string model, int year, double mileage, int doors)
    {
        return CreateCar(brand, model, year, mileage, 4); // Antag att 4 dörrar som standard
    }
}

public interface IVehicleFactory
{
}