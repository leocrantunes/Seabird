using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabird
{
    public sealed class Aircraft : IAircraft
    {
        private const int AircraftTakeOffHeight = 200;
        private const bool IsAirborne = true;
        private const bool IsNotAirborne = false;
        public bool Airborne { get; private set; }
        public int Height { get; private set; }

        public Aircraft()
        {
            Height = 0;
            Airborne = IsNotAirborne;
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            Airborne = IsAirborne;
            Height = AircraftTakeOffHeight; // Meters
        }

    }
}
