namespace ProductLibrary;

public class Product
{
    public int productID;
    public String productName;
    public int quantityInStock;
    public readonly String createdDate;

    public Product()
    {
        createdDate = DateTime.Now.ToShortDateString();
    }
}
