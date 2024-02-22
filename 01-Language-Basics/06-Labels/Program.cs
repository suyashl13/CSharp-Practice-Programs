class Program
{
    static void Main()
    {

        int gotoCounter = 3;

        Console.WriteLine("AUS");
        Console.WriteLine("NZ");
        Console.WriteLine("PAK");
        Console.WriteLine("BAN");
    myCountry:
        Console.WriteLine("IND");
        gotoCounter--;
        if (gotoCounter > 0)
        {
            goto myCountry;
        }
        Console.WriteLine("CA");
        Console.WriteLine("MX");
        Console.WriteLine("SA");
        Console.WriteLine("CHI");
        Console.WriteLine("JAP");

    }
}