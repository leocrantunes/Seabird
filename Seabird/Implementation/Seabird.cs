using Seabird.Interface;
using System;

namespace Seabird.Implementation
{
    /// <summary>
    /// Seabird Adapter class
    /// </summary>
    public class Seabird : Seacraft, IAircraft
    {
        private const int SeabirdTakeoffHeight = 50;
        private const int RateOfClimb = 100;
        private const int HeightClimbSpeed = 40;
        private const double DegreeIncreaseRate = 10.0;

        /// <summary>
        /// Routes this straight back to the Aircraft
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Calculated property to indicate 
        /// if seabird is flying
        /// </summary>
        public bool Airborne
        {
            get
            {
                return Height > SeabirdTakeoffHeight;
            }
        }

        /// <summary>
        /// Nose degree state
        /// </summary>
        public double Degree { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Seabird()
        {
            Height = 0;
            Degree = 0;
        }

        /// <summary>
        /// A two-way adapter hides and routes the Target's methods
        /// Use Seacraft instructions to implement this one
        /// </summary>
        public void TakeOff()
        {
            RaiseNose();
            while (!Airborne)
            {
                IncreaseRevs();
            }
            Console.WriteLine("Seabird took off");
        }

        /// <summary>
        /// Method responsible for the landing process
        /// </summary>
        public void Land()
        {
            LowerNose();
            while (Airborne)
            {
                DecreaseRevs();
            }
            Console.WriteLine("Seabird landed");
        }

        /// <summary>
        /// Increases speed
        /// This method is common to both Target and Adaptee
        /// </summary>
        public override void IncreaseRevs()
        {
            base.IncreaseRevs();
            if (Speed > HeightClimbSpeed)
            {
                Height += RateOfClimb;
            }
        }

        /// <summary>
        /// Decreases speed
        /// </summary>
        public override void DecreaseRevs()
        {
            base.DecreaseRevs();
            if (Speed > 0)
            {
                Height -= RateOfClimb;
            }
        }

        /// <summary>
        /// Raises node at a specific degree
        /// </summary>
        public void RaiseNose()
        {
            Degree += DegreeIncreaseRate;
            Console.WriteLine($"Seabird raised nose to {Degree} degrees");
        }

        /// <summary>
        /// Lowers node at a specific degree
        /// </summary>
        public void LowerNose()
        {
            if (Airborne)
            {
                Degree -= DegreeIncreaseRate;
                Console.WriteLine($"Seabird lowered nose to {Degree} degrees");
            }
            else
            {
                Console.WriteLine("It is not possible to lower nose when seabird is not flying");
            }
        }
    }
}