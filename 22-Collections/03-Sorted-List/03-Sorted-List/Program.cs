class Program {
    static void Main() 
    {
        SortedList<int, String> employees = new()  {
            { 101, "AAA" },
            {102, "BBB"},
            {103, "CCC"},
            {108, "DDD"}
        };

        // Adding Items in sorted list
        employees.Add(105, "FFF");
        employees.Add(107, "HHH");

        // Removing elements from employees.
        employees.Remove(103);

        foreach (KeyValuePair<int, string> item in employees)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        // Check if key contains
        bool doesExist = employees.ContainsKey(103);
        String resultMessage = doesExist ? "Found" : "Not Found";

        Console.WriteLine($"Employee with key 103 was {resultMessage}");

        Console.WriteLine($"Found DDD at {employees.IndexOfValue("DDD")}");


    }
}