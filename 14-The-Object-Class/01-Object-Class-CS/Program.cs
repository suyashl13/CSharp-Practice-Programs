using ClassLibrary;

class Program
{
    static void Main()
    {
        Person person1 = new Person(){
            PersonName = "Suyash",
            Email = "suyash.lawand@gmail.com",
        };

        Person person2 = new Person(){
            PersonName = "Suyash",
            Email = "suyash.lawand@gmail.com",
        };

        Console.WriteLine($"Person1 equals Person2: {person1.Equals(person2)}");
        Console.WriteLine($"{person1.ToString()}");
    }
}