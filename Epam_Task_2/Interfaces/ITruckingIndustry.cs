namespace Epam_Task_2.Interfaces
{
    /// <summary>
    /// This interface describing trucking industry
    /// </summary>
    internal interface ITruckingIndustry
    {
        /// <summary>
        /// Method for getting a specific semitrailer
        /// </summary>
        /// <returns>Object of type a specific semitrailer</returns>
        ISemitrailer GetSemitrailer();
    }
}
