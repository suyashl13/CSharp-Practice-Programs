using ClassLibrary;

class Program
{
    static void Main() {
        Employee employeeOne = new Employee(1001, "Suyash Lawand", "Developer");
        Employee employeeTwo = new Employee(1002, "Tim Cook", "CEO");
        Employee employeeThree = new Employee(1003, "Bill Gates", "CFO");
        Employee employeeFour = new Employee() {
            // Object initializer syntax
            employeeID = 1004,
            employeeName = "Elon Musk",
            job = "CEO"
        };

        // Display Fields
        Console.WriteLine($"========= {Employee.companyName} LTD. =========\n");
        Console.WriteLine($"Employee ID: {employeeOne.employeeID}, Name: {employeeOne.employeeName}, Position: {employeeOne.job}");
        Console.WriteLine($"Employee ID: {employeeTwo.employeeID}, Name: {employeeTwo.employeeName}, Position: {employeeTwo.job}");
        Console.WriteLine($"Employee ID: {employeeThree.employeeID}, Name: {employeeThree.employeeName}, Position: {employeeThree.job}");
        Console.WriteLine($"Employee ID: {employeeFour.employeeID}, Name: {employeeFour.employeeName}, Position: {employeeFour.job}");
    }
}