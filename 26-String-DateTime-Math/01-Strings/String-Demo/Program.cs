class Program
{
    static void Main()
    {
        String myName = "Suyash";
        Console.WriteLine(myName.ToUpper()); // Returns uppercased String without modifying current one.
        Console.WriteLine(myName.ToLower());

        // Substrings
        String message = "hi, good morning my name is suyash";
        Console.WriteLine(message.Substring(17));
        Console.WriteLine(message.Substring(17, 2));

        // Replace
        message = "Rock on!";
        Console.WriteLine(message.Replace('R', 'F'));

        // Split (Returns array based on seperator)
        Console.WriteLine(String.Join(", ", message.Split(" ")));

        // Trim Removes unnecessary start and end spaces
        String s = "  Hi  ";
        Console.WriteLine(s.Length);
        Console.WriteLine(s.Trim().Length);


        // String Checking
        // Check for equality
        String str1 = "Suyash";
        String str2 = "Lawand";
        Console.WriteLine($"Are both strings same? {str1.Equals(str2)}");

        // With ==
        Console.WriteLine($"Are both strings same? {str1 == str2}");

        // Starts With
        Console.WriteLine($"{str1} Starts with 'S'? {str1.StartsWith('S')}");


        // Ends with
        Console.WriteLine($"{str2} Ends with 'and'? {str2.EndsWith("and")}");

        // Contains
        String email = "suyash.lawand@gmail.com";
        Console.WriteLine($"{email} has '@'? {email.Contains('@')}");


        // IndexOf
        int indexOfAtR = email.IndexOf('@');
        Console.WriteLine($"Index of @ is {indexOfAtR}");

        // LastIndexOf  
        Console.WriteLine($"Last index of a is {email.LastIndexOf('a')}");

        String input = Console.ReadLine()!;
        if (String.IsNullOrEmpty(input))
        {
            Console.WriteLine($"{input} is null or empty");
        }
        else Console.WriteLine($"{input} is valid and great string.");

        // Formatted string
        Console.WriteLine(String.Format("{0} is example of {1} string", "This", "is"));

        // Insert a string inside a string
        Console.WriteLine("Hello, Suyash".Insert(0, "Hey "));

        // Remove demo
        Console.WriteLine("Hello, Suyash".Remove(0,4));
    }
}