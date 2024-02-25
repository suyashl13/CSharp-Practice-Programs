using ClassLibrary;

class Program
{
    static void Main()
    {
        Employee employee = new Employee()
        {
            EmpID = 1500,
            EmployeeName = "Suyash Lawand",
            Job = "Developer"
        };

        employee.NativePlace = "Pune, Maharashtra";
        employee.Tax = 12;

        Console.WriteLine($"ID: {employee.EmpID}");
        Console.WriteLine($"Name: {employee.EmployeeName}");
        Console.WriteLine($"Job: {employee.Job}");
        Console.WriteLine($"Native Place: {employee.NativePlace}");
    }
}