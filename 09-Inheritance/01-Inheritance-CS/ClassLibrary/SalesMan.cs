namespace ClassLibrary;

class SalesMan: Employee
{
    // fields
    private String _region;

    public SalesMan(int empID, String empName, String location, String region) : base(empID, empName, location) {
        this.Region = region;
    }
    
    // Properties
    public String Region {
        get => _region;
        set => _region = value;
    }
}