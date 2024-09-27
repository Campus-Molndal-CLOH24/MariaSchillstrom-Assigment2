using MariaSchillstrom_Assigment2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaSchillstrom_Assigment2.Interfaces
{

    public interface IMotorCycle : IVehicle, IDrivable
    {
        string EngineType { get; set; }//Specifik egensap för motorcykel

    }

}






