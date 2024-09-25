using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;



    public interface IMotorCycle : IVehicle, IDriveable

    {
        string EngineType { get; set; }
        
    }



