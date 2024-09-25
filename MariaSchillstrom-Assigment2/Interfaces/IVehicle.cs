using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaSchillstrom_Assigment2.Interfaces
{
    internal class IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double mileage { get; set; }
        
        private bool engineOn;
        
        public bool IsEngineOn => engineOn;

        public void StartEngine()
        {
            engineOn = true;
        }
        public void StopEngine()
        {
            engineOn = false;
        }

    }
}
