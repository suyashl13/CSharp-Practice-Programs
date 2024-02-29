namespace ClassLibrary;

class DestructorExample
{
    public DestructorExample() {
        Console.WriteLine("Constructor Executed.");
    }

    ~DestructorExample() {
        Console.WriteLine("Destructor executed and Object of class released from heap.");
    }
}