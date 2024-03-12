using System.Globalization;

public class Person
{
    public Guid PersonId { get; set; }
    public String? Name { get; set; }
    public int Age { get; set; }

    public DateTime DateOfBirth { get; set; }
}

class Program
{
    public static void Main() {
        Person suyash = new Person() {
            PersonId = Guid.NewGuid(),
            Name = "Suyash",
            Age = 23
        };

        suyash.DateOfBirth = DateTime.Parse("06-13-2001");

        Console.WriteLine(suyash.DateOfBirth.DayOfWeek);

        Console.WriteLine("DOB: ");

        Console.WriteLine(suyash.DateOfBirth.Date);
        Console.WriteLine(suyash.DateOfBirth.Month);
        Console.WriteLine(suyash.DateOfBirth.Year);

        // Extra methods
        DateTime dateTime = Convert.ToDateTime("2020-12-31 11:50:59.999");
        String str1 = dateTime.ToString("");

        Console.WriteLine(str1);
        Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));

        // Date Substraction
        DateTime dateOfJoining = DateTime.ParseExact("31-12-2020", "dd-MM-yyyy",
            CultureInfo.InvariantCulture  
        );

        TimeSpan timeSpan = DateTime.Now.Subtract(dateOfJoining);
        Console.WriteLine($"Difference between dat joined and today is: {timeSpan.Days} Days");

        // Adding Days to todays date
        DateTime today = DateTime.Now;
        

        Console.WriteLine("After 10 days: " + today.AddDays(10));
        Console.WriteLine("After 1 Month" + today.AddMonths(1));


    }
}

