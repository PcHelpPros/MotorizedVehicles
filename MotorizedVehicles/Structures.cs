using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorizedVehicles;

namespace Structures
{
    public struct Automobile : IMotorizedVehicle
    {
        private bool isDriving;
        public EngineType EngineType { get; set;}
        public int NoOfTires { get;set;}
        public string Brakes { get; set; }
        public string Transmission { get;set; }
        public bool Driving()
        {
            return Driving(isDriving);
        }       

        public bool Driving(bool isDriving)
        {
            this.isDriving = isDriving;
            if (this.isDriving) return true;
            return false;
        }
    }
}
