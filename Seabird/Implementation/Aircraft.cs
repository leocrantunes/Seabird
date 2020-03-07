using Seabird.Interface;
using System;

namespace Seabird.Implementation
{
    /// <summary>
    /// Standard aircraft class
    /// </summary>
    public sealed class Aircraft : IAircraft
    {
        private const int AircraftTakeOffHeight = 200;
        private const bool IsAirborne = true;
        private const bool IsNotAirborne = false;
        private const double DefaultNoseDegrees = 10.0;

        public bool Airborne { get; private set; }
        
        public int Height { get; private set; }

        public double Degree { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Aircraft()
        {
            Height = 0;
            Airborne = IsNotAirborne;
        }

        /// <summary>
        /// Execute airplane taking off process 
        /// </summary>
        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            Airborne = IsAirborne;
            Height = AircraftTakeOffHeight; // Meters
        }

        /// <summary>
        /// Execute airplane landing process
        /// </summary>
        public void Land()
        {
            Console.WriteLine("Aircraft engine land");
            Airborne = IsNotAirborne;
            Height = 0; // Meters
        }

        /// <summary>
        /// Raises node to a specific degree
        /// </summary>
        public void RaiseNose()
        {
            Degree += DefaultNoseDegrees;
        }

        /// <summary>
        /// Lower node to a specific degree
        /// </summary>
        public void LowerNose()
        {
            Degree -= DefaultNoseDegrees;
        }
    }
}