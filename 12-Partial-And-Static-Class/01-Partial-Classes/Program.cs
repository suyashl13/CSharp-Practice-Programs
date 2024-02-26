using ClassLibrary;

class Program
{
    static void Main() {
        Product pen = new Product();
        Console.WriteLine(pen.GetCategory());
    }
}