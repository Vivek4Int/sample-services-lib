namespace SampleServices;

public class OrderService
{
    public Order GetOrder(int id) =>
        new(id, 1, 149.99m);
}
