namespace Seabird.Interface
{
    /// <summary>
    /// ITarget interface
    /// </summary>
    public interface IAircraft
    {
        int Height { get; }

        double Degree { get; }

        bool Airborne { get; }

        void TakeOff();

        void Land();

        void RaiseNose();

        void LowerNose();
    }
}