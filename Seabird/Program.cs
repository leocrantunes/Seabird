using Seabird.Interface;
using System;

using SeabirdImpl = Seabird.Implementation.Seabird;
using AircraftImpl = Seabird.Implementation.Aircraft;

namespace Seabird
{
    /// <summary>
    /// Main program class
    /// </summary>
    class Program
    {
        static void Main()
        {
            ExecuteExperiment1();

            IAircraft seabird = new SeabirdImpl();
            ExecuteExperiment2(seabird);
            ExecuteExperiment3(seabird);

            Console.WriteLine("Experiments successful; the Seabird flies!");

            ExecuteExperiment4();

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
                Console.WriteLine("The aircraft engine is fine, flying at " 
                    + aircraft.Height + " meters");
            }
        }

        /// <summary>
        /// Experiment 2: Classic usage of an adapter
        /// </summary>
        private static void ExecuteExperiment2(IAircraft seabird)
        {
            Console.WriteLine("\nExperiment 2: Use the engine in the Seabird");

            ISeacraft seacraft = seabird as ISeacraft;

            seacraft.TurnOnEngine();
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
            Console.WriteLine("\nExperiment 3: Increase the speed of the Seabird");

            ISeacraft seacraft = seabird as ISeacraft;

            seacraft.TurnOnEngine();
            seacraft.IncreaseRevs();
            seacraft.IncreaseRevs();

            if (seabird.Airborne)
            {
                Console.WriteLine("Seabird flying at height " 
                    + seabird.Height + " meters and speed " + 
                    (seabird as ISeacraft).Speed + " knots");
            }
        }

        /// <summary>
        /// Experiment 4 execution
        /// </summary>
        private static void ExecuteExperiment4()
        {
            Console.WriteLine("\nExperiment 4");

            IAircraft seabird = new SeabirdImpl();
            ISeacraft seacraft = seabird as ISeacraft;

            PrepareToTakeoff(seacraft);
            seabird.TakeOff();
            PrintFlightStatus(seabird);
            seacraft.IncreaseRevs();
            PrintFlightStatus(seabird);
            seacraft.Wait(15);
            seabird.LowerNose();
            PrintFlightStatus(seabird);
            seacraft.Wait(15);
            seabird.Land();
            PrintFlightStatus(seabird);
            seabird.RaiseNose();
            seacraft.DecreaseRevs();
            seacraft.DecreaseRevs();
            seacraft.DecreaseRevs();
            PrintFlightStatus(seabird);
            seacraft.Wait(5);
            seacraft.DecreaseRevs();            
            seacraft.DecreaseRevs();
            seacraft.TurnOffEngine();
        }

        /// <summary>
        /// Print flight status
        /// </summary>
        /// <param name="seabird"></param>
        private static void PrintFlightStatus(IAircraft seabird)
        {
            if (seabird.Airborne)
            {
                Console.WriteLine("Seabird flying at height " + seabird.Height
                    + " meters and speed " + (seabird as ISeacraft).Speed + " knots");
            }
            else
            {
                Console.WriteLine($"Seabird on ground at speed {(seabird as ISeacraft).Speed} knots");
            }
        }

        /// <summary>
        /// Execute procedures preparing to take off
        /// </summary>
        /// <param name="seacraft"></param>
        public static void PrepareToTakeoff(ISeacraft seacraft)
        {
            seacraft.TurnOnEngine();
            seacraft.IncreaseRevs();
            seacraft.DecreaseRevs();
            seacraft.DecreaseRevs();
            seacraft.Wait(2);
        }
    }
}