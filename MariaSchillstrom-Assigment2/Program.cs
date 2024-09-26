using MariaSchillstrom_Assigment2.Models;
using MariaSchillstrom_Assigment2.Factories;
using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assignment_2.InterFaces;
using System.Reflection;


    class Program
{
    private static void Main()
    {
        List<IVehicle> vehicles = new List<IVehicle>();
        List<IDrivable> vehicleList = new List<IDrivable>();

        var carFactory = new CarFactory();
        var motorcycleFactory = new MotorcycleFactory();
        

        IVehicle car1 = carFactory.CreateVehicle("Volvo", "V70", 2010, 10000);
        IVehicle car2 = carFactory.CreateVehicle("Saab", "900", 1995, 20000);
        IVehicle car3 = carFactory.CreateVehicle("Audi", "A4", 2018, 5000);

        IVehicle motorcycle1 = motorcycleFactory.CreateVehicle("Yamaha", "R1", 2015, 5000);
        IVehicle motorcycle2 = motorcycleFactory.CreateVehicle("Honda", "CBR", 2010, 10000);
        IVehicle motorcycle3 = motorcycleFactory.CreateVehicle("Kawasaki", "Ninja", 2018, 2000);




        vehicles.Add(car1);
        vehicles.Add(car2);
        vehicles.Add(car3);
        vehicles.Add(motorcycle1);
        vehicles.Add(motorcycle2);
        vehicles.Add(motorcycle3);

        // Gå igenom varje fordon i listan och hantera bil och motorcykel specifikt
        foreach (IVehicle vehicle in vehicles)
        {
            // Starta motorn för alla fordo
            // 
            vehicle.StartEngine();

            
    {
        
    }



}
    }
}