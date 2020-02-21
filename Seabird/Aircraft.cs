using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabird
{
    public sealed class Aircraft : IAircraft
    {
        private int height;
        private bool airborne;
        private const int AircraftTakeOffHeight = 200;
        private const bool IsAirborne = true;
        private const bool IsNotAirborne = false;

        public bool Airborne
        {
            get { return airborne; }
        }

        public int Height
        {
            get { return height; }
        }

        public Aircraft()
        {
            height = 0;
            airborne = IsNotAirborne;
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            airborne = IsAirborne;
            height = AircraftTakeOffHeight; // Meters
        }

    }
}
