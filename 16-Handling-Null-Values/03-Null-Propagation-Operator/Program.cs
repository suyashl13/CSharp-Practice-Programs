internal class Person
{
    public int? Age {get; set;}
}

class Program{
    static void Main() {
        Person person = new Person();

        // This 
        Console.WriteLine(
            (person.Age == null) ? null : Convert.ToString(person.Age)
        );

        // Is equivalent to this
        Console.WriteLine(
            person?.Age
        );

    }
}