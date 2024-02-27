using ClassLibrary;

class Program
{
    static void Main()
    {
        MarksPrinter<PostGraduateStudent> marksPrinter = new MarksPrinter<PostGraduateStudent>()
        {
            Student = new PostGraduateStudent() { Marks = 50 }
        };

        marksPrinter.PrintMarks();
    }
}