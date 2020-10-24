using System;
namespace csharp_playground
{
    public class PhysicalProductModel : IProductModel
    {
       public string Title { get; set; }
       public bool HasOrderBeenCompleted { get; set; }

       public void ShipItem(CustomerModel customer)
       {
           if (HasOrderBeenCompleted == false)
           {
               Console.WriteLine($"Simulating shipping { Title } to {customer.FirstName} in {customer.City}");
               HasOrderBeenCompleted = true;
           }

       } 
    }
}