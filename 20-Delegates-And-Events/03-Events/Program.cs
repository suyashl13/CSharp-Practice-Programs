using ClassLibrary;

class Program
{
    static void Main() {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        publisher.MyEvent += subscriber.Add;
        publisher.RaiseEvent(2, 2);
    }
}