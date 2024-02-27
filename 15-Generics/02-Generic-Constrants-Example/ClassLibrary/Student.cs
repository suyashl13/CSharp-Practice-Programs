namespace ClassLibrary;

public abstract class Student {
    public abstract int Marks {get; set; }
}

public class GradStudent : Student
{
    public override int Marks { get; set; }
}

public class PostGraduateStudent : Student
{
    public override int Marks { get; set; }
}

// We restricted the T to be of only child of student or Student class itself
public class MarksPrinter<T>where T: Student
{
    public T Student {get; set;}
    public void PrintMarks() { 
        Console.WriteLine($"Marks of student: {Student.Marks}");
    }
}
