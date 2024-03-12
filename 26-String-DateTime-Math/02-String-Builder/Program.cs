using System.Text;

class Program
{
    public static void Main() {
        String aaa = "AAA";
        StringBuilder stringBuilder = new(aaa);

        for (int i = 0; i < 100; i++)
        {
            stringBuilder.Append(i);
        }

        Console.WriteLine(stringBuilder.ToString().Replace("5", "FIVE"));

        // Insert at spefic index.
        Console.WriteLine(stringBuilder.Insert(3, "Hello"));

        Console.WriteLine(stringBuilder.ToString());
    }
}