namespace csharp_playground
{
    public interface IDigitalProductModel : IProductModel
    {
         int TotalDownLoadsLeft { get; set; }
    }
}