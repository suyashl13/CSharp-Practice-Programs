class Sample {
    static void Main() {
        // Declare a as 100;
        int age = 30;
        String userName = "Suyash";


        // Print Value
        Console.WriteLine(age);

        // Get a character form user 
        Console.ReadLine();

        // Print
        Console.Write("Hi, " + userName + " ");
        Console.Write("Your age is ");
        Console.WriteLine(age);
        
        int maxInt = int.MaxValue;
        int minInt = int.MinValue;

        Console.Write("Maximum Length of int: ");
        Console.WriteLine(maxInt);

        Console.Write("Minimum Length of int: ");
        Console.WriteLine(minInt);

        Console.Write("Default value of int: ");
        Console.WriteLine(default(int));

    }
}