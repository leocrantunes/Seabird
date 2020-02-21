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
        private int speed;

        private const int Acceleration = 10;

        public int Speed
        {
            get { return speed; }
        }

        public Seacraft()
        {
            speed = 0;
        }

        public virtual void IncreaseRevs()
        {
            speed += Acceleration;
            Console.WriteLine("Seacraft engine increases revs to " + speed + " knots");
        }
    }
}
