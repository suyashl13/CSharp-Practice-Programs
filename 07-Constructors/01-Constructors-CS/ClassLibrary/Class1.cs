namespace ClassLibrary;

public class Employee
{
    public int employeeID;
    public String job;
    public String employeeName;
    public static String companyName;

    public Employee() {
        this.employeeID = 0;
        this.employeeName = null;
        this.job = null;
    }


    // Parametrized constructor
    public Employee(int employeeID, String employeeName, String job) { 
        this.employeeID = employeeID;
        this.employeeName = employeeName;
        this.job = job;
    }

    /* Static Constructor is called only once when the class is loaded in memory, 
    They cannot have parameters; */
    static Employee() {
        companyName = "Cognizant";
    }
}
