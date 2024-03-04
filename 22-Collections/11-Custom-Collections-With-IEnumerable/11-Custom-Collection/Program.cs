using ClassLibrary;

class Program
{
    static void Main() {
        CustomerList customerList = new CustomerList();
        customerList.Add(
            new Customer("AAA")
        );
        customerList.Add(
            new Customer("BBB")
        );
        customerList.Add(
            new Customer("CCC")
        );
        customerList.Add(
            new Customer("DDD")
        );
        customerList.Add(
            new Customer("FFF")
        );


        foreach (Customer item in customerList)
        {
            Console.WriteLine($"{item.CustomerID}. {item.CustomerName}");
        }

    }
}