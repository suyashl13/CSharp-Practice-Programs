namespace ClassLibrary;

public class Product
{
    private static int _instanceCount = 0;
    
    private readonly int _id;
    public String Name { get; set; } = "";
    public double Price { get; set; }
    public float Rating {get; set; } = 0;

    public Product(String name, double price) {
        this.Name = name;
        this.Price = price;
        this._id = ++_instanceCount;
    }

    public int Id {get => _id; }

}
