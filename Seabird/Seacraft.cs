using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabird
{
    // Adaptee implementation
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
