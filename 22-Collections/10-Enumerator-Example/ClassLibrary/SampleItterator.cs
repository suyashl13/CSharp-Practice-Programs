namespace ClassLibrary;

public class SampleIterator
{
    private readonly int[] ints = [1,2,3,4,5,6,7,8,9,0];
    public IEnumerable<int> Method() { 
        for (int index = 0; index < ints.Length; index++)
        {
            yield return ints[index];
        }
    }
}