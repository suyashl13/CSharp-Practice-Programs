namespace ClassLibrary;

public class Sample: IDisposable
{
    public Sample() {
        Console.WriteLine("Database Connected...");
    }

    public void ReadDataFromDatabase() {
        Console.WriteLine("Read data from database");
    }

    public void Dispose()
    {
        Console.WriteLine("Database Disconnected...");
    } 

}
