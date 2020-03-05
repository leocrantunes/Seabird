using Seabird.Interface;
using System;

using SeabirdImpl = Seabird.Implementation.Seabird;
using AircraftImpl = Seabird.Implementation.Aircraft;

namespace Seabird
{
    class Program
    {
        static void Main()
        {
            ExecuteExperiment1();
            IAircraft seabird = new SeabirdImpl();
            ExecuteExperiment2(seabird);
            ExecuteExperiment3(seabird);

            Console.WriteLine("Experiments successful; the Seabird flies!");
            Console.ReadLine();
        }

        /// <summary>
        /// Experiment 1: No adapter
        /// </summary>
        private static void ExecuteExperiment1()
        {
            Console.WriteLine("Experiment 1: test the aircraft engine");
            IAircraft aircraft = new AircraftImpl();
            aircraft.TakeOff();
            if (aircraft.Airborne)
            {
                Console.WriteLine("The aircraft engine is fine, flying at " + aircraft.Height + " meters");
            }
        }

        /// <summary>
        /// Experiment 2: Classic usage of an adapter
        /// </summary>
        private static void ExecuteExperiment2(IAircraft seabird)
        {
            Console.WriteLine("\nExperiment 2: Use the engine in the Seabird");
            seabird.TakeOff(); // And automatically increases speed
            Console.WriteLine("The Seabird took off");
        }

        /// <summary>
        /// Experiment 2: Two-way adapter
        /// Using seacraft instructions on an IAircraft object
        /// (where they are not in the IAircraft interface)
        /// </summary>
        private static void ExecuteExperiment3(IAircraft seabird)
        {
            Console.WriteLine("\nExperiment 3: Increase the speed of the Seabird:");
            (seabird as ISeacraft).IncreaseRevs();
            (seabird as ISeacraft).IncreaseRevs();
            if (seabird.Airborne)
            {
                Console.WriteLine("Seabird flying at height " + seabird.Height + " meters and speed " + (seabird as ISeacraft).Speed + " knots");
            }
        }
    }
}
