class Program {
    static void Main() {
        HashSet<String> employeeNames = [
            "Suyash",
            "Bill",
            "James",
            "Will",
            "John",
            "James B.",
            "Steve",
        ];

        // Remove based on values.
        employeeNames.Remove("Suyash");

        // Remove based on conditions (Has spaces);
        employeeNames.RemoveWhere(empName => empName.Split(" ").Length > 1);

        // Add
        employeeNames.Add("Elon Musk");

        // See if contains
        bool isPresent = employeeNames.Contains("Suyash"); // false as it was removed.
        Console.WriteLine($"Suyash is in list ? {isPresent}");

        // traverse
        foreach (String item in employeeNames) {
            Console.WriteLine($"Item: {item}");
        }


        // Clear
        employeeNames.Clear();
    }
}