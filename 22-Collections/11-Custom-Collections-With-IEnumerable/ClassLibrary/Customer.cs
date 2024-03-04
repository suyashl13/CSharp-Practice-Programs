public class Customer
{
    public String CustomerName { get; set; } = "";
    private int _customerID;
    public int CustomerID
    {
        get { return _customerID; }
    }
    private static int _customerCount = 0;

    public Customer(String name) {
        CustomerName = name;
        _customerID = ++_customerCount;
    }
}