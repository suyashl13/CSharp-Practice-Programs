using ClassLibrary;

class Program
{
    static void Main()
    {
        List<Employee> employees = [
            new Employee() { EmployeeID = 1001, EmployeeName = "Suyash Lawand", City = "Pune", Job = "Software Developer" },
            new Employee() { EmployeeID = 1002, EmployeeName = "James Bond", City = "Las Vegas", Job = "Stock Broker" },
            new Employee() { EmployeeID = 1003, EmployeeName = "Annie Marrie", City = "London", Job="Musician" },
            new Employee() { EmployeeID = 1004, EmployeeName = "John Doe", City = "London", Job="Musician" },
            new Employee() { EmployeeID = 1005, EmployeeName = "Jane William", City = "London", Job="Musician" },
            new Employee() { EmployeeID = 1006, EmployeeName = "Lorem Ipsum", City = "London", Job="Musician" }
        ];

        var result = employees.Where(employee => employee.City == "London");
        foreach (Employee employee in result)
        {
            Console.WriteLine(employee.EmployeeName + " " + employee.Job);
        }
        Console.WriteLine();

        IOrderedEnumerable<Employee> empOrderedByName = employees.OrderBy(employee => employee.EmployeeName).ThenBy(emp => emp.Job);
        foreach (Employee employee in result)
        {
            Console.WriteLine(employee.EmployeeName + " " + employee.Job);
        }
        Console.WriteLine();

        // First Demo
        Employee firstManager = employees.First((employee) => employee.EmployeeID == 1003); // If not then throws exception
        Console.WriteLine(firstManager?.EmployeeName);

        // First or default
        Employee? employee1 = employees.FirstOrDefault((employee) => employee.EmployeeID == 122);
        if (employee1 == null)
        {
            Console.WriteLine("Emp was null");
        }
        else
        {
            Console.WriteLine($"{employee1.EmployeeName} (employee1.Job)");
        }

        // Last and LastOrDefault are same.

        // Element At Demo
        Employee employee2 = employees.Where(emp => emp.City == "London").ElementAt(2); // Returns ith matching element
        Console.WriteLine(employee2.EmployeeName);

        // Single (Must return only one element throws error if returns more than one)
        Employee employee3 = employees.Single(employee => employee.EmployeeID == 1001);
        Console.WriteLine(employee3.EmployeeName);

        // SingleOrDefault return an default value if conditions are not met.
        Employee? employee4 = employees.SingleOrDefault(emp => emp.City == "London");
        Console.WriteLine(employee4 == null ? "Empty" : employee4.EmployeeName);

        IEnumerable<int> peopleIdEnummerable = employees.Select(employee => employee.EmployeeID);

        // IDs of Employee.
        foreach (int id in peopleIdEnummerable)
        {
            Console.WriteLine(id);
        }
    }
}