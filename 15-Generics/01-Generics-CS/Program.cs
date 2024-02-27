using ClassLibrary;

class Program
{
    static void Main()
    {
        User<int, int> user1 = new User<int, int>
        {
            RegistrationStatus = 1001,
            Age = 21
        };

        User<bool, String> user2 = new User<bool, String>
        {
            RegistrationStatus = false,
            Age = "20 - 25"
        };

        // In Real projects use generic types <T> 
        // where your are not sure about the datatype.
        Console.WriteLine($"\n=== User 1 ===");
        Console.WriteLine($"Registration Status: {user1.RegistrationStatus}");
        Console.WriteLine($"Age : {user1.Age}");

        Console.WriteLine($"\n=== User 2 ===");
        Console.WriteLine($"Registration Status: {user2.RegistrationStatus}");
        Console.WriteLine($"Age : {user2.Age}");
    }
}