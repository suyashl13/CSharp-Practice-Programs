using System.Collections;

class Program
{
    static void Main() {
        Hashtable hashtable = new() {
            {1001, "AAA"},
            {1002, "BBB"},
            {1003, "CCC"},
            {1004, "DDD"},
            {1007, "EEE"},
            {"AAA", 111}
        };

        bool has1001 = hashtable.Contains(1001);
        Console.WriteLine(has1001);

        // Adding to hash table
        hashtable.Add(1006, "HHH");
        hashtable.Add(1005, "RRR");
        hashtable.Add("BBB", 2222);

        // Removing from hashtable
        hashtable.Remove("BBB");

        // Looping through hashtable keys.
        foreach (var key in hashtable.Keys)
        {
            Console.WriteLine($"{key}: {hashtable[key]}");
        }
    }
}