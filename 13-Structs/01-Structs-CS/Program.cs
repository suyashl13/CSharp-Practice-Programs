class Program {
    static void Main() {
        Category clothing = new Category(){
            CategoryID = 1,
            CategoryName = "Clothing"
        };

        // Accessing Structure's data
        Console.WriteLine($"Category Id: {clothing.CategoryID}");
        Console.WriteLine($"Category Name: {clothing.CategoryName}");

        Marvel marvel = new Marvel("Spyderman"); // Marvel is readonly struct;
        marvel.PrintCharacterName();
        

    }
}