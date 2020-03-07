using Seabird.Interface;
using System;

namespace Seabird.Implementation
{
    /// <summary>
    /// Seacraft Adaptee implementation
    /// </summary>
    public class Seacraft : ISeacraft
    {
        private const int Acceleration = 10;

        public bool IsTurnedOn { get; protected set; }

        public int Speed { get; protected set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Seacraft()
        {
            Reset();
        }

        /// <summary>
        /// Increases seacraft speed
        /// </summary>
        public virtual void IncreaseRevs()
        {
            if (IsTurnedOn)
            {
                Speed += Acceleration;
                Console.WriteLine($"Seacraft engine increases revs to {Speed} knots");
            }
            else
            {
                Console.WriteLine("Seacraft engine is not turned on");
            }
        }

        /// <summary>
        /// Decreases seacraft speed
        /// </summary>
        public virtual void DecreaseRevs()
        {
            if (IsTurnedOn)
            {
                if (Speed == 0)
                {
                    Console.WriteLine("Seacraft engine is already stopped");
                }
                else
                {
                    Speed -= Acceleration;
                    Console.WriteLine($"Seacraft engine decreases revs to {Speed} knots");
                }
                
            }
            else
            {
                Console.WriteLine("Seacraft engine is not turned on");
            }
        }

        /// <summary>
        /// Turn engine on
        /// </summary>
        public void TurnOnEngine()
        {
            if (IsTurnedOn) 
            {
                Console.WriteLine("Seacraft engine has already turned on");
            }
            else
            {
                IsTurnedOn = true;
                Console.WriteLine("Seacraft engine turned on");
            }
        }

        /// <summary>
        /// Turn engine off
        /// </summary>
        public void TurnOffEngine()
        {
            if (!IsTurnedOn)
            {
                Console.WriteLine("Seacraft engine has already turned off");
            }
            else
            {
                Reset();
                Console.WriteLine("Seacraft engine turned off");
            }
        }

        /// <summary>
        /// Wait for some a specific time in the same state
        /// </summary>
        /// <param name="minutes"></param>
        public void Wait(int minutes)
        {
            Console.WriteLine($"Seacraft engine remains at the same state for {minutes} minutes");
        }

        /// <summary>
        /// Reset to original state
        /// </summary>
        private void Reset()
        {
            Speed = 0;
            IsTurnedOn = false;
        }
    }
}
