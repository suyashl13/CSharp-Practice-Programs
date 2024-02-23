using ProductLibrary;

class Program
{
    // Static fields;
    private static readonly int someNumber = 69;
    private const String companyName = "Coditas";

    static void Main()
    {
        Product product1, product2, product3;

        // Initialize
        product1 = new Product
        {
            productID = 1001 + someNumber,
            productName = "Laptop",
            quantityInStock = 100
        };

        // Product 2
        product2 = new Product
        {
            productID = 1002,
            productName = "Mobile",
            quantityInStock = 200
        };

        // Product 3
        product3 = new Product
        {
            productID = 1003,
            productName = "Tab",
            quantityInStock = 50
        };


        // Get Properties
        Console.WriteLine("Product Id (1):" + product1.productID);
        Console.WriteLine("Product Name (1):" + product1.productName);
        Console.WriteLine("Product Quantity In Stock (1):" + product1.quantityInStock);

        Console.WriteLine("----------------------------------");

        Console.WriteLine("Product Id (2):" + product2.productID);
        Console.WriteLine("Product Name (2):" + product2.productName);
        Console.WriteLine("Product Quantity In Stock (2):" + product2.quantityInStock);

        Console.WriteLine("----------------------------------");

        Console.WriteLine("Product Id (3):" + product3.productID);
        Console.WriteLine("Product Name (3):" + product3.productName);
        Console.WriteLine("Product Quantity In Stock (3):" + product3.quantityInStock);
        Console.WriteLine("Product creation time (3): " + product3.createdDate);

        Console.WriteLine("\nCurrent Stock in " + companyName + " is " + (product1.quantityInStock
            + product2.quantityInStock + product3.quantityInStock
        ));
    }
}