using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int NumberOfTires { get; set; }
        int Year { get; set; }
    }
}
