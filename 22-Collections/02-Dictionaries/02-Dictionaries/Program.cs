class Program
{
    static void Main()
    {
        // Dictionaries
        Dictionary<string, string> states = new Dictionary<string, string>() {
            {"MH", "Maharashtra"},
        };
        states.Add("NY", "New York");


        foreach (KeyValuePair<string, string> state in states)
        {
            Console.WriteLine($"{state.Key}: {state.Value}");
        }

        // Get element by index
        Console.WriteLine("MH:= " + states["MH"]);

        // Removing the element
        bool isRemoved = states.Remove("NY");
        if (isRemoved)
        {
            Console.WriteLine("Removed NY from states");
        }

        // Contains key
        bool isKey = states.ContainsKey("NY");

        // Contains value
        bool isValue = states.ContainsValue("New York");

        Console.WriteLine(isKey + " " + isValue);

        // Removing all
        states.Clear();

        // Print all keys;
        foreach (string key in states.Keys)
        {
            Console.WriteLine(key);
        }
    }
}