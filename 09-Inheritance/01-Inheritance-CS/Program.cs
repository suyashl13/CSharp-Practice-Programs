using ClassLibrary;

sealed class Program // No any class can inherit from Program Class
{
    static void Main() {
        Employee employee = new Employee(1000, "Suyash", "Chandigarh");

        Console.WriteLine("(Employee)");
        Console.WriteLine($"Employee Name: {employee.EmpName}");
        Console.WriteLine($"Employee ID: {employee.EmpID}");
        Console.WriteLine($"Employee Location: {employee.Location}");


        Manager manager = new Manager(1001, "James", "Chandigarh", "Management");

        Console.WriteLine("\n(Manager)");
        Console.WriteLine($"Manager Name: {manager.EmpName}");
        Console.WriteLine($"Manager ID: {manager.EmpID}");
        Console.WriteLine($"Manager Location: {manager.Location}");
        Console.WriteLine($"Manager Department: {manager.GetFullDepartmentNameWithLocation()}");
        Console.WriteLine($"Healhth Insurance Status: {manager.GetHealthInsuranceMessage()}");

        SalesMan salesMan = new SalesMan(1002, "John", "Chandigarh", "South");

        Console.WriteLine("\n(SalesMan)");
        Console.WriteLine($"SalesMan Name: {salesMan.EmpName}");
        Console.WriteLine($"SalesMan ID: {salesMan.EmpID}");
        Console.WriteLine($"SalesMan Location: {salesMan.Location}");

    }
}