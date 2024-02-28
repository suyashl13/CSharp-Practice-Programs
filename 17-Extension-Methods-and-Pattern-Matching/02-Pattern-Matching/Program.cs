using ClassLibrary;

class Program
{
    static void Main() {
        Parent parent = new Child() {
            Y = "YYYY"
        };
        parent.X = "XXXX";

        if (parent is Child cc)
        {
            Console.WriteLine($"Child is parent of Parent Class");
            Console.WriteLine(cc.Y);
        }
    }
}