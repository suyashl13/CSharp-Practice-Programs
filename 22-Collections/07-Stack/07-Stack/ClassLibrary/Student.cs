namespace ClassLibrary;

public class Student
{
    public String Name { get; set; }
    public int Marks { get; set; }

    public int Rank { get; set; }

    public Student(String name, int marks) {
        this.Name = name;
        this.Marks = marks;
    }

    public override string ToString()
    {
        return this.Name;
    }

}