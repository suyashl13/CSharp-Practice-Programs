class Person
{
    private int _workProofHash;
    public int WorkProofHash
    {
        get { return _workProofHash; }
    }
    public String Name {get; set; } = "";

    public void DoWork(int workProfHash){
        this._workProofHash = workProfHash;
        Console.WriteLine($"{Name} was assigned a work proof hash of {_workProofHash}");
    }

    public Person(String name) {
        this.Name = name;
    }

}

class Program
{
    static void Main()
    {
        Queue<Person> peopleQueue = new();

        peopleQueue.Enqueue(new Person("AAA"));
        peopleQueue.Enqueue(new Person("BBB"));
        peopleQueue.Enqueue(new Person("CCC"));
        peopleQueue.Enqueue(new Person("DDD"));

        int index = 0;
        foreach (Person person in peopleQueue.ToArray())
        {
            Person dequeuedPerson = peopleQueue.Dequeue();
            dequeuedPerson.DoWork(++index);
        }
    }
}