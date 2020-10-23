namespace csharp_playground
{
    public interface IProductModel
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; set; }
        void ShipItem(CustomerModel customer);
    }
}