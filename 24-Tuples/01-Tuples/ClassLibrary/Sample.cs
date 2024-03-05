namespace ClassLibrary;

public class Sample
{
    public Tuple<string, int> GetPersonDetails()
    {
        return new Tuple<string, int>("James", 20);
    }
}

public class Customer
{
    public (int Id, String Name, String Email) GetCustomerDetails() {
        return (Id: 1001, Name: "Suyash", Email: "suyash.lawand@gmail.com");
    }
}