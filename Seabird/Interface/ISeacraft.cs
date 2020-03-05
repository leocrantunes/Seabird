namespace Seabird.Interface
{
    /// <summary>
    /// Adaptee interface
    /// </summary>
    public interface ISeacraft
    {
        int Speed { get; }

        void IncreaseRevs();
    }
}
