using MariaSchillstrom_Assigment2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaSchillstrom_Assigment2.Interfaces
{
        public interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double mileage { get; set; }

        bool IsEngineOn();  
        void StartEngine();
        void StopEngine();

    }
}




