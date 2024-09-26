using MariaSchillstrom_Assigment2.Interfaces;
using MariaSchillstrom_Assigment2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace MariaSchillstrom_Assigment2.Interfaces
    {
        public interface IVehicle
        {
            string Brand { get; }
            string Model { get; }
            int Year { get; }
            double Mileage { get; }
            bool IsEngineOn { get; }

            void StartEngine();
            void StopEngine();
        }
    }


