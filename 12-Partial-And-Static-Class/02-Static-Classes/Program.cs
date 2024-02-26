using ClassLibrary;

class Program
{
    static void Main() {
        Person suyash = new Person() {
            Name = "Suyash",
            ageGroup = AgeGroup.ADULT,
            Address = "Pune, Katraj"
        };
        Constants.isLoading = false;
        Console.WriteLine($"Is Loading {Constants.isLoading}");
        Console.WriteLine("====== Person Info =====");
        Console.WriteLine($"Name: {suyash.Name}");
        Console.WriteLine($"Age Group: {suyash.ageGroup}");
        Console.WriteLine($"Address: {suyash.Address}");
    }
}