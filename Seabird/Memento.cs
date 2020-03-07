namespace Seabird
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        public int Height { get; private set; }

        public bool IsTurnedOn { get; private set; }

        public int Speed { get; private set; }

        public double Degree { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="height"></param>
        /// <param name="isTurnedOn"></param>
        /// <param name="speed"></param>
        public Memento(int height, bool isTurnedOn, int speed, double degree)
        {
            this.Height = height;
            this.IsTurnedOn = isTurnedOn;
            this.Speed = speed;
            this.Degree = degree;
        }
    }
}
