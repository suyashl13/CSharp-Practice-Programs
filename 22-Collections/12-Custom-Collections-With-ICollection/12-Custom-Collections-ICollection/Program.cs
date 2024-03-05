using ClassLibrary;

class Program
{
    static void Main() {
        CustomerList customers = new CustomerList();
        
        customers.Add(new Customer("Suyash"));
        customers.Add(new Customer("BBB"));
        customers.Add(new Customer("CCC"));
        customers.Add(new Customer("EEE"));

        foreach (var customer in customers)
        {
            Console.WriteLine(customer.CustomerName);
        }
    }
}