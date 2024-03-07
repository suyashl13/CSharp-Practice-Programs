using ClassLibrary;

class Program
{
    static void Main() {
        List<Employee> employeeList = [
            new Employee(id: 1001, employeeName: "AAA",city: "Pune", salary: 13200),
            new Employee(id: 1002, employeeName: "BBB",city: "Mumbai", salary: 12320),
            new Employee(id: 1003, employeeName: "CCC",city: "Latur", salary: 73200),
            new Employee(id: 1004, employeeName: "DDD",city: "Beed", salary: 52210),
            new Employee(id: 1005, employeeName: "EEE",city: "Aurangabad", salary: 10997),
            new Employee(id: 1006, employeeName: "FFF",city: "Pune", salary: 87200),
            new Employee(id: 1007, employeeName: "GGG",city: "Mysore", salary: 21200),
        ];

        // Min of all salaries
        double minimumSalary = employeeList.Min(employee => employee.Salary);
        Console.WriteLine($"Lowest salary is: {minimumSalary}");

        double maximumSalary = employeeList.Max(employee => employee.Salary);
        Console.WriteLine($"Maximum Salary is: {maximumSalary}");

        double averageSalary = employeeList.Average(employee => employee.Salary);
        Console.WriteLine($"Average Salary: {averageSalary}");

        Console.WriteLine($"Total Employees: {employeeList.Count()}");
    }
}