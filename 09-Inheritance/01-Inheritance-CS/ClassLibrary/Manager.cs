namespace ClassLibrary;

class Manager: Employee
{
    // Field
    private String _departmentName;
    
    public Manager(int empID, String empName, String location, String departmentName) : base(empID, empName, location){
        this.DepartmentName = departmentName;
    }

    // Properties
    public String  DepartmentName { 
        get => _departmentName;
        set => _departmentName = value;
    }

    public String GetFullDepartmentNameWithLocation() => $"{this._departmentName} at {base.Location}."; // base keyword. 

    // Hided using new keyword
    public new String GetHealthInsuranceMessage() {
        return "Issued health insurance for " + this.EmpName + " of Rs. " + 500;
    }

    // Ovveriden Methof of base class

    public sealed override String GetIncentives() {
        Console.WriteLine(base.GetIncentives());
        return "Incentives for " + base.EmpName + " of Rs. " + 2000;
    }

}