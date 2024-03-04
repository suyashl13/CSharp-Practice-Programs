using ClassLibrary;

class Program
{
    static void Main() {
        SampleIterator sampleIterator = new();
        var enumerator = sampleIterator.Method().GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
    }
}