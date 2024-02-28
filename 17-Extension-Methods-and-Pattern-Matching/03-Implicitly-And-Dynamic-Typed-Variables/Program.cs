class Program
{
    // Implicitly typed variables.
    static void Main() {
        var myName = "Suyash Lawand";
        myName = "Some  other name"; //Can be reassigned with same datatype.
        // myName = 22; // This is not allowed in var keyword.
        
        dynamic age = 23;
        age = "10 - 25"; //This is allowed in dynamic keyword.
    }
}