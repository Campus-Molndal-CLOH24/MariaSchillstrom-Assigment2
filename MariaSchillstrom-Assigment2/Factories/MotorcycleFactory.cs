using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;

public class MotorcycleFactory : IVehicleFactory
{
    public MotorcycleImpl CreateMotorcycle(string brand, string model, int year, int mileage, string engineType)
    {
        return new MotorcycleImpl(brand, model, year, mileage, engineType);
    }

    public IVehicle CreateVehicle(string brand, string model, int year, int mileage, string engineType)
    {
        return (IVehicle)CreateMotorcycle(brand, model, year, mileage, engineType);
    }
}


