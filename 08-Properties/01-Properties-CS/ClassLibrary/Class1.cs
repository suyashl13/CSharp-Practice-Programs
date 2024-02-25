namespace ClassLibrary;

public class Employee
{
    private int _empID;
    private String _job;
    private String _employeeName;
    private int _salary;
    private static String companyName;

    private int _tax;

    public Employee() { 
        this._empID = 0;
        this._employeeName = null;
        this._job = null;
    }

    public int EmpID {
        set { 
            if (value > 1000){
                _empID = value; 
            } else
            {
                Console.WriteLine("Employee ID should be greater than 1000");
            }
            
        }
        get { return _empID; }
    }

    public int Salary {
        // Readmonly property.
        get { return _salary; }
    }

    public int Tax {
        set => _tax = value;
    }

    // This is auto implemented property
    public String NativePlace { get; set; } = "New Delhi"; // New delhi is auto implemented property.

    public String Job {
        set { _job = value; }
        get { return _job; }
    }

    public String EmployeeName {
        set { _employeeName = value; }
        get { return _employeeName; }
    }

    // Parametrized constructor
    public Employee(int employeeID, String employeeName, String job) { 
        this._empID = employeeID;
        this._employeeName = employeeName;
        this._job = job;
    }

    /* Static Constructor is called only once when the class is loaded in memory, 
    They cannot have parameters; */
    static Employee() {
        companyName = "Cognizant";
    }
}
