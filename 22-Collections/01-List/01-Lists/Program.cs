class Program
{
    static void Main()
    {
        List<int> numbersList = [10, 20, 30];

        // Add item 
        numbersList.Add(40);

        // Adding other list
        List<int> numbersList2 = [50, 60, 70, 60];
        List<int> numbersList3 = [150, 160, 170, 160];

        // Adding other list
        numbersList.AddRange(numbersList2);

        // Adding the element at specified index
        numbersList.Insert(3, 60);
        numbersList.InsertRange(3, numbersList3);

        // Remove item from spefic index.
        numbersList.RemoveAt(4);

        // Remove based on condition
        numbersList.RemoveAll(number => number % 20 != 0); // True means element will be removed. 

        // Removing the element
        bool isRemoved = numbersList.Remove(60);
        if (isRemoved)
        {
            Console.WriteLine($"60 is removed from the list");
        }


        // IndexOf: returns -1 if not found. and index is returned if found.
        int index = numbersList.IndexOf(60);
        Console.WriteLine($"60 found at {index}");

        // Sorting the list
        numbersList.Sort();

        // Reverse the list
        numbersList.Reverse();

        // Converting the list to array
        int[] numbersArray = numbersList.ToArray();

        // For Each Method
        numbersList.ForEach((number) => Console.WriteLine(number));

        Console.WriteLine(numbersList.Exists(number => number > 55));


        // Failed Marks
        Console.WriteLine(numbersList.Find(marks => marks < 35));
        
        // Failed Marks Index
        Console.WriteLine(numbersList.FindIndex(marks => marks < 35));

        List<String> strings = numbersList.ConvertAll<String>((n) => String.Format("{0}", n));
        Console.WriteLine(String.Join(", ", strings.ToArray()));
    }
}