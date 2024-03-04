class Program
{
    static void Main()
    {
        int[] ints = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 13 };

        // Accessing elements form ints using for loop.
        for (int index = 0; index < ints.Length; index++)
        {
            Console.WriteLine($"index: {index} Element: {ints[index]}");
        }

        Console.WriteLine();
        // Accessing elements from foreach
        // Foreach is based on sequence;
        foreach (var item in ints)
        {
            Console.WriteLine($"Element: {item}");
        }

        Console.WriteLine();
        // IndexOf method
        int indexOf3 = Array.IndexOf(ints, 3);
        Console.WriteLine($"The position of 3 in array is {indexOf3}");

        Console.WriteLine();
        int indexOf3After3Index = Array.IndexOf(ints, 3, 3);
        Console.WriteLine(indexOf3After3Index); // -1 Not found after 3rd index

        Console.WriteLine();
        Console.WriteLine(Array.BinarySearch(ints, 8));

        //       to assign!  ! till index;
        Array.Clear(ints, 0, 5);
        foreach (var item in ints)
        {
            Console.WriteLine($"Element: {item}");
        }

        // Resize Array
        Console.WriteLine();
        Array.Resize(ref ints, 4);
        foreach (var item in ints)
        {
            Console.WriteLine($"Element: {item}");
        }
    }
}