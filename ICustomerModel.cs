namespace csharp_playground
{
    public interface ICustomerModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string City { get; set; }
        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
    }
}