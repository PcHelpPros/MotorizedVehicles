using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotorizedVehicles;
using System.Threading.Tasks;
using Structures;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Coupe coupe = new Coupe();
                coupe.Brakes = "disc";
                coupe.EngineType = EngineType.V8;
                coupe.NoOfTires = 1;

                Automobile auto = new Automobile();
                auto.Brakes = "disc";
                auto.EngineType = EngineType.V8;

                Coupe coupeTwin = coupe;
                coupeTwin.EngineType = EngineType.V6;
                Console.WriteLine($"coupe has enginetype {coupe.EngineType.ToString()}");

                Automobile autoTwin = auto;
                autoTwin.EngineType = EngineType.V6;
                Console.WriteLine($"auto has enginetype {auto.EngineType.ToString()}");
            }
            catch (System.Exception e)
            {
                {throw e;}
            }
            
        }
    }
}
