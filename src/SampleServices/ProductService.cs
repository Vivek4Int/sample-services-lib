namespace SampleServices;

public class ProductService
{
    public Product GetProduct(int id) =>
        new(id, "Widget Pro", 29.99m);
}
