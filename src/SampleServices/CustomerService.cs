namespace SampleServices;

public class CustomerService
{
    public Customer GetCustomer(int id) =>
        new(id, "Alice Smith", "alice@example.com");
}
