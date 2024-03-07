namespace ClassLibrary;

public class Employee
{
    public int Id { get; set; }
    public String EmployeeName { get; set; } = "";
    public String City { get; set; } = "";
    public double Salary { get; set; }

    public Employee(int id, String employeeName, String city, double salary)
    {
        this.Id = id;
        this.EmployeeName = employeeName;
        this.City = city;
        this.Salary = salary;
    }

}
