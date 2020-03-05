namespace Seabird.Interface
{
    /// <summary>
    /// ITarget interface
    /// </summary>
    public interface IAircraft
    {
        int Height { get; }

        bool Airborne { get; }

        void TakeOff();
    }
}