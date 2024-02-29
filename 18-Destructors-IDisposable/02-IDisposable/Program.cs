using ClassLibrary;

class Program
{
    static void Main() {
        using (Sample sample = new Sample())
        {
            sample.ReadDataFromDatabase();
        }

        Console.WriteLine("Connection Ended...");
    }
}