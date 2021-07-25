namespace Epam_Task_2.Interfaces
{
    /// <summary>
    /// This interface describing products that special thermal conditions
    /// </summary>
    internal interface ISpecialThermal
    {
        public int MinTemperature { get; }
        public int MaxTemperature { get; }
    }
}
