using MariaSchillstrom_Assigment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaSchillstrom_Assignment_2.InterFaces
{

    public interface ICar : IVehicle, IDrivable
    {
        int Doors { get; set; }
    }
}

