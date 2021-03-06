namespace Epam_Task_2.Interfaces
{
    /// <summary>
    /// This interface describing tractor
    /// </summary>
    internal interface ITractor
    {
        ISemitrailer Semitrailer { get; set; }
        double Weight { get; }
        string WheelFormule { get; }
        int FuelCapacity { get; }
        double EngineVolume { get; }
        string Cabin { get; }
        double FifthWheelHeight { get; }
        double FifthWheelLoad { get; }
        double FullWeight { get; }
    }
}
