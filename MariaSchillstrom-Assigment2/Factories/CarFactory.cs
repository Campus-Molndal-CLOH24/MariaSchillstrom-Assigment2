using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assignment_2.Models;

public class CarFactory : IVehicleFactory
{
   
    public CarImpl CreateCar(string brand, string model, int year, int mileage, string engineType, int doors)
    {
        return new CarImpl(brand, model, year, mileage, engineType, doors);
    }

    public IVehicle CreateVehicle(string brand, string model, int year, int mileage, string engineType)
    {
       
        return (IVehicle)CreateCar(brand, model, year, mileage, engineType, 5);
    }
}
