using ClassLibrary;

class Program
{
    static void Main()
    {
        // Object of sample class.
        Sample sample = new Sample();

        // create deligates or objects;
        MyDeligateType myDeligate = new MyDeligateType(sample.Add);

        Console.WriteLine(myDeligate.Invoke(1,2));
        Console.ReadKey();

    }
}