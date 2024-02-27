namespace ClassLibrary;

public class Employee
{
    public int Salary;
}

public class Student
{
    public int Marks;
}

// A Class with generic method;
public class Sample
{
    public void PrintData<T>(T obj) where T : class
    {
        if (obj.GetType() == typeof(Student))
        {
            Student student = obj as Student;
            Console.WriteLine($"Marks: {student.Marks}");
        }
        else if (obj.GetType() == typeof(Employee))
        {
            Employee employee = obj as Employee;
            Console.WriteLine($"Salary: {employee.Salary}");
        }
    }
}
