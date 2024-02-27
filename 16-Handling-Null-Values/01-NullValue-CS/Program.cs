using ClassLibrary;

class Program
{
    static void Main() {

        //Person is null initially.
        Person person = new Person() {
            Age = 18,
            NoOfChildren = null,
        };

        Console.WriteLine(person.Age); // 18
        Console.WriteLine(person.NoOfChildren); // Null
    }
}