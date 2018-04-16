using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorizedVehicles
{
    interface IMotorizedVehicle
    {
        EngineType EngineType { get; set;}
        int NoOfTires { get; set;}
        string Brakes { get; set;}
        string Transmission { get; set;}

        bool Driving();
        bool Driving(bool isDriving);
    }
}
