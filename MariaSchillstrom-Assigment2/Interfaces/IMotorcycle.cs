using MariaSchillstrom_Assigment2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaSchillstrom_Assigment2.Interfaces
{

    public interface IMotorCycle : IVehicle, IDriveable
    {
        string EngineType { get; set; }
        
    }

    public interface IDriveable
    {
    }
}
    
    
