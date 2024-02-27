using ClassLibrary;

class Program
{
    static void Main() {
        Sample sample = new Sample();
        Student student = new Student() { Marks = 89 };
        
        Employee employee = new Employee() {Salary = 50000};
        
        //We can pass the params of both employee and student types and get desired output.
        sample.PrintData<Student>(student);  // Marks: 89
        sample.PrintData<Employee>(employee); // Salary: 50000
    }
}