namespace Epam_Task_2.Interfaces
{
    /// <summary>
    /// This interface describing semitrailer
    /// </summary>
    internal interface ISemitrailer
    {
        public string Type { get; }
        public string WheelFormula { get; }
        public double GetCurrentCapacity();
        public void SetCurrentCapacity(double value);
        public double MaxCapacity { get; }
        public double BodyVolume { get; }
        public string DischargeDirection { get; }
        public double FifthWheelHeight { get; }
        public double BodyLength { get; }

        /// <summary>
        /// Method for adding product in semitrailer
        /// </summary>
        /// <param name="product">this product</param>
        public void AddProduct(IProduct product);
    }
}
