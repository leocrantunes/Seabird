using Seabird.Interface;
using System;

namespace Seabird.Implementation
{
    /// <summary>
    /// Adaptee implementation
    /// </summary>
    public class Seacraft : ISeacraft
    {
        private const int Acceleration = 10;

        public int Speed{ get; private set; }

        public Seacraft()
        {
            Speed = 0;
        }

        public virtual void IncreaseRevs()
        {
            Speed += Acceleration;
            Console.WriteLine("Seacraft engine increases revs to " + Speed + " knots");
        }
    }
}
