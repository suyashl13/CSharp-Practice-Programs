namespace ClassLibrary;

public delegate void MyDelegateType(int a, int b);

class Publisher
{
    // Private Delegate
    private event MyDelegateType MyDelegate;

    //Step 1: Create Event.
    public event MyDelegateType MyEvent 
    {
        add {
            MyDelegate += value;
        }
        remove {
            MyDelegate -= value;
        }
    }

    public void RaiseEvent(int a, int b) {

        // Step 2: Raise Event
        MyDelegate?.Invoke(a, b);
    }
}
