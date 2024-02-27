// variableName ?? valueOfNull

using ClassLibrary;

class Program {
    static void Main() {
        Person suyash = new Person() {
            Age = 23, 
            NoOfChildren = null
        };

        suyash.NoOfChildren ??= 0; // Equivalent To: suyash.NoOfChildren = suyash.NoOfChildren ??= 0;
        Console.WriteLine($"Age: {suyash.Age}");
        Console.WriteLine($"No of Children: {suyash.NoOfChildren}");

    }
}