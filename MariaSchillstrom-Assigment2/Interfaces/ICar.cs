using MariaSchillstrom_Assigment2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaSchillstrom_Assigment2.Interfaces
{
    public interface IMotorcycle : IVehicle, IDrivable
    { 
        int Doors { get; set; }
    }      
          
    
    }

