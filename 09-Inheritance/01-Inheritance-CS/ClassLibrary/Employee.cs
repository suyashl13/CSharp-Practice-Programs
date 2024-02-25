namespace ClassLibrary;

public class Employee
{ 
    // Fields
    private int _empID;
    private String _empName;
    private String _location;

    // Properties
    public int EmpID {
        get {
            return _empID;
        }
        set {
            _empID = value;
        }
    }

    public Employee(int empID, String empName, String location) {
        this.EmpID = empID;
        this.EmpName = empName;
        this.Location = location;
    }

    public String EmpName {
        get => _empName;
        set => _empName = value;
    }

    public String Location {
        get => _location;
        set => _location = value;
    }

    // Some public Method 
    public  String GetHealthInsuranceMessage() {
        return "Issued health insurance for " + this.EmpName + " of Rs. " + 500;
    }


    public virtual String GetIncentives() => "Incentives for " + this.EmpName + " of Rs. " + 1000;

}