namespace ClassLibrary;

sealed public class Operations
{
    public void Add(int numberOne, int numberTwo)
    {
        Console.WriteLine($"Addition of {numberOne} and {numberTwo} is {numberOne + numberTwo}");
    }

    public void Multiply(int numberOne, int numberTwo)
    {
        Console.WriteLine($"Multiplication of {numberOne} and {numberTwo} is {numberOne * numberTwo}");
    }
}

