using Seabird.Interface;

namespace Seabird.Implementation
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class Seabird : Seacraft, IAircraft
    {
        private const int SeabirdTakeoffHeight = 50;
        private const int RateOfClimb = 100;
        private const int HeightClimbSpeed = 40;

        /// <summary>
        /// Routes this straight back to the Aircraft
        /// </summary>
        public int Height { get; private set; }

        public bool Airborne
        {
            get { return Height > SeabirdTakeoffHeight; }
        }

        public Seabird()
        {
            Height = 0;
        }

        /// <summary>
        /// A two-way adapter hides and routes the Target's methods
        /// Use Seacraft instructions to implement this one
        /// </summary>
        public void TakeOff()
        {
            while (!Airborne)
            {
                IncreaseRevs();
            }
        }

        /// <summary>
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
    }
}
