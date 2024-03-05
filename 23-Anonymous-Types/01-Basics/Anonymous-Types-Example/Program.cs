using ClassLibrary;

class Program
{
    static void Main() 
    {
        Person person = new() {
            Name = "Suyash",
            Email = "suyash.lawand@gmail.com",
            Age = 23
        };

        // Anonymous Type.
        var anotherAnonymousPerson = new {
            Name = person.Name,
            Profession = "Professor",
            Email = "suyash.lawand@gmail.com",
            Age = 22,
            Gender = "M",
            Phone = "9545731113"
        };

        // By default the properties of anonymous types are readonly.
        // anotherAnonymousPerson.Email = "suyash.lawand@hiresuyash.com" [ERROR].

        // Nested Anonymous Objects.
        var person2 = new {
            Name = "Suyash",
            Email = "suyash.lawand@gmail.com",
            // Here address is nested under another anonymous object person2.
            Address  = new {
                ApartmentNo = "X1321",
                SocietyName = "Apex Heights",
                Street = "London - Satara Road"
            }
        };

        // Anonymous objects inside an array;
        var people = new[] {
            new { Person = "Suyash", Age=23 },
            new { Person = "James Bond", Age=79 },
        };


    }
}