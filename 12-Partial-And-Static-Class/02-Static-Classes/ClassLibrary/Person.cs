namespace ClassLibrary;

public class Person
{
    public String Name { get; set; }

    public String Address { get; set; }

    public AgeGroup ageGroup {get; set;}
}

public enum AgeGroup {
    CHILD,
    TEENAGER,
    ADULT,
    SENIOR_CITIZEN
}