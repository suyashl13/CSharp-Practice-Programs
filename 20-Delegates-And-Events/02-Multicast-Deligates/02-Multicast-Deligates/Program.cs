using ClassLibrary;

class Program
{
    static void Main()
    {
        Operations operations = new Operations();

        // Deligate
        OperationsDeligate operationsDeligate;
        operationsDeligate = operations.Add;
        operationsDeligate += operations.Multiply;

        operationsDeligate.Invoke(5, 6);
        Console.ReadKey();
    }
}