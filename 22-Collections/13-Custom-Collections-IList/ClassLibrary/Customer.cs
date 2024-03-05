namespace ClassLibrary;

public class Customer : IEquatable<Customer>
{
    private static int CustomerCount = 0;
    private int _customerID;
    public int CustomerID
    {
        get { return _customerID; }
        set { _customerID = value; }
    }
    public String CustomerName { get; set; } = "";
    public String CustomerEmail { get; set; } = "";

    public Customer(String customerName, String customerEmail) {
        this.CustomerName = customerName;
        this.CustomerEmail = customerEmail;
        _customerID = ++CustomerCount;
    }

    public bool Equals(Customer? other)
    {
        return this._customerID == other.CustomerID && this.CustomerName == other?.CustomerName && this.CustomerEmail == other?.CustomerEmail;
    }
}
