namespace ClassLibrary;

class Program {
    static void Main() {
        Customer customer = new Customer();
        Sample sample = new Sample();
        Tuple<string, int> personDetails = sample.GetPersonDetails();

        Console.WriteLine(personDetails);
        // Also we can get Values based on items.
        Console.WriteLine(String.Format("{0}, {1}", personDetails.Item1, personDetails.Item2));


        // Lets see value tuples.
        var customerDetails = customer.GetCustomerDetails();
        Console.WriteLine($"{customerDetails.Name}, {customerDetails.Email}, {customerDetails.Id}");

        // Destructuring
        (int Id, String Name, _) = customer.GetCustomerDetails(); // Add _ to skip the values
        Console.WriteLine($"{Id}, {Name}");

        
    }
}