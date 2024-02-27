class Program
{
    static void Main() {
        // Boxing

        // value type 
        int xInt = 10;

        // reference type
        object yObject = xInt;

        Console.WriteLine($"xInt: {xInt}, yObject: {yObject}");

        // Unboxing.
        // Reference type
        object myNameAsRef = "Suyash Lawand";

        // value type
        String myNameAsString = (String) myNameAsRef;


        Console.WriteLine($"{myNameAsRef}, {myNameAsString}");
    }
}