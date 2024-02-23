namespace ClassLibrary;

public class Product
{
    private int productID;

    private float cost;
    private double tax;
    private String productName;
    private int quantityInStock;
    private readonly String createdDate;
    private static int totalNoOfProducts = 0;

    public Product()
    {
        createdDate = DateTime.Now.ToShortDateString();
        totalNoOfProducts++;
    }

    public void CalculateTax(ref double percentage)
    {
        double tax;

        // Calculate Tax
        if (cost <= 2000)
        {
            tax = cost * 10 / 1000;
        }
        else
        {
            tax = cost * percentage * 10 / 1000;
        }

        this.tax = tax;
    }

    public void CalculateTax( double taxPercentageForBPL, double percentage = 12.5) // Methpd overloading
    {
        double tax;

        // Calculate Tax
        if (cost <= 2000)
        {
            tax = cost * taxPercentageForBPL * 10 / 1000;
        }
        else
        {
            tax = cost * percentage * 10 / 1000;
        }

        this.tax = tax;
    }


    // getters and setters for productId.
    public int GetProductId() { return this.productID; }
    public void SetProductID(int productID) { this.productID = productID; }


    // Getters and Setters for Product Name
    public String GetProductName() { return this.productName; }
    public void SetProductName(String productName) { this.productName = productName; }


    // Getters and Setters for Quantity in stock.
    public int GetQuantityInStock() { return this.quantityInStock; }
    public void SetQuantityInStock(int quantityInStock) { this.quantityInStock = quantityInStock; }


    // Getters and Setters for Cost
    public double GetCost() { return this.cost; }
    public void SetCost(float cost)
    {
        this.cost = cost;
        double percentage = 12.5;
        // this.CalculateTax(percentage: 12.5); // Named parameter
        this.CalculateTax(ref percentage); //ref is used wen u can only pass variable and not actual value;
    }

    //Getter for createdAt
    public String GetCreateAt() { return createdDate; }

    // Getter for Tax.
    public double GetTax() {return this.tax;}

    // Example of static method.
    public static int GetTotalNoOfProducts() {return totalNoOfProducts; }

    public static int GetTotalQuantity(params Product[] products) { // Can give no of params in function
        int totalQuantity = 0;
        for (int i = 0; i < products.Length; i++)
        {
            totalQuantity += products[i].quantityInStock;
        }
        return totalQuantity;
    } 
}
