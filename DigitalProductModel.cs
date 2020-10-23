using System;
namespace csharp_playground
{
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; set; }
        public int TotalDownLoadsLeft { get; set; } = 5;
        public void ShipItem(CustomerModel customer)
        {
            Console.WriteLine($"Emailing {Title} to {customer.EmailAddress} in {customer.City}");
            TotalDownLoadsLeft -= 1;
            if (TotalDownLoadsLeft < 1)
            {
                HasOrderBeenCompleted = true;
                TotalDownLoadsLeft = 0;
            }
        }
    }
}