using System.Collections;

class Program
{
    static void Main()
    {
        // Array list can hold data of any data type.
        ArrayList arrayList = new() {
            "Suyash", 1 ,2, 3
        };

        arrayList.Add(66);
        arrayList.Add("Lorem ipsum conser let amet qusew");
        arrayList.Add(true);


        arrayList.AddRange(new ArrayList() { "Suyash", 1, 2, 3333, "AAA", 3, false });

        foreach (var item in arrayList)
        {
            if (item is String s)
            {
                Console.WriteLine("Item was string.");
                Console.WriteLine("Item in uppercase: " + s.ToUpper());
            }
            else
            {
                Console.WriteLine(item);
            }
        }
    }
}