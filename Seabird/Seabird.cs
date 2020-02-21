using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabird
{
    // Adapter
    public class Seabird : Seacraft, IAircraft
    {
        private int height;
        private const int SeabirdTakeoffHeight = 50;
        private const int RateOfClimb = 100;
        private const int HeightClimbSpeed = 40;

        // Routes this straight back to the Aircraft
        public int Height
        {
            get { return height; }
        }

        public bool Airborne
        {
            get { return height > SeabirdTakeoffHeight; }
        }

        public Seabird()
        {
            height = 0;
        }

        // A two-way adapter hides and routes the Target's methods
        // Use Seacraft instructions to implement this one
        public void TakeOff()
        {
            while (!Airborne)
            {
                IncreaseRevs();
            }
        }

        // This method is common to both Target and Adaptee
        public override void IncreaseRevs()
        {
            base.IncreaseRevs();
            if (Speed > HeightClimbSpeed)
            {
                height += RateOfClimb;
            }
        }
    }
}
