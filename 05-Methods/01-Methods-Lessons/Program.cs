using ClassLibrary;

class Program
{
    // Static fields;
    private static readonly int someNumber = 69;
    private const String companyName = "Amazon India";

    static void Main()
    {
        Product product1, product2, product3;

        // Initialize
        product1 = new Product();
        product1.SetProductID(1001);
        product1.SetCost(5999);
        product1.SetQuantityInStock(5);
        product1.SetProductName("iPhone");

        

        // Product 2
        product2 = new Product();
        product2.SetProductID(1002);
        product2.SetCost(9199);
        product2.SetQuantityInStock(51);
        product2.SetProductName("Samsung A56");

        // Product 3
        product3 = new Product();
        product3.SetProductID(1003);
        product3.SetCost(35999);
        product3.SetQuantityInStock(10);
        product3.SetProductName("Samsung Tab S23");


        // Get Properties
        Console.WriteLine("Product Id (1): " + product1.GetProductId());
        Console.WriteLine("Product Name (1): " + product1.GetProductName());
        Console.WriteLine("");
        Console.WriteLine("Product Quantity In Stock (1): " + product1.GetQuantityInStock());
        Console.WriteLine("Tax for Product (1): "+ product1.GetTax());

        Console.WriteLine("----------------------------------");
        
        Console.WriteLine("Product Id (2): " + product2.GetProductId());
        Console.WriteLine("Product Name (2): " + product2.GetProductName());
        Console.WriteLine("Product Quantity In Stock (2): " + product2.GetQuantityInStock());
        Console.WriteLine("Tax for Product (2): "+ product2.GetTax());

        Console.WriteLine("----------------------------------");

        Console.WriteLine("Product Id (3): " + product3.GetProductId());
        Console.WriteLine("Product Name (3): " + product3.GetProductName());
        Console.WriteLine("Product Quantity In Stock (3): " + product3.GetQuantityInStock());
        Console.WriteLine("Tax for Product (3): "+ product3.GetTax());

        Console.WriteLine("----------------------------------");
        

        Console.WriteLine("\nCurrent Stock in " + companyName + " is " + (Product.GetTotalQuantity(
            product1, product2, product3
        )
        ));

        Console.WriteLine("Total No. of Products: " + Product.GetTotalNoOfProducts());

    }
}