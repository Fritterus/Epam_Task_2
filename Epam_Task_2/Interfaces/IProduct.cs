namespace Epam_Task_2.Interfaces
{
    internal interface IProduct
    {
        public string Type { get; }
        public string Name { get; }
        public int Quantity { get; }
        public double WeightPerUnit { get; }
    }
}
