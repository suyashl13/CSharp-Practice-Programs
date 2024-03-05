namespace ClassLibrary;

class Program
{
    static void Main()
    {
        CustomerList customers =
        [
            new Customer(
                customerName: "Suyash",
                customerEmail: "suyash.lawand@gmail.com"
            )
,
            new Customer(
                customerName: "Suyash2",
                customerEmail: "suyash.lawand@gmail.com"
            )
,
            new Customer(
                customerName: "Suyash3",
                customerEmail: "suyash.lawand@gmail.com"
            )
,
            new Customer(
                customerName: "Suyash4",
                customerEmail: "suyash.lawand@gmail.com"
            )
,
        ];
        
        Customer customer = new(customerName: "Suyash", customerEmail: "suyash.lawand@gmail.com");
        customer.CustomerID = 1;
        Console.WriteLine(
            customers.Contains(customer)
        );
    }
}