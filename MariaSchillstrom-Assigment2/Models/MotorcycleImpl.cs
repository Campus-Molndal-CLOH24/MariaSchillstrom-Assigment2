
using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaSchillstrom_Assigment2.Models;

public class MotorcycleImpl : IMotorcycle
{
    public MotorcycleImpl(string brand, string model, int year, int mileage, string engineType)
    {
        Brand = brand;
        Model = model;
        Year = year;
        this.mileage = mileage;
    }

    public int Doors { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double mileage { get; set; }
    public bool EngineOn { get; set; }
    public string Drive { get; set; }

    public bool IsEngineOn => EngineOn;

    public void StartEngine()
    {
        EngineOn = true;
    }

    public void StopEngine()
    {
        EngineOn = false;
    }
}

public interface IMotorcycle
{
}