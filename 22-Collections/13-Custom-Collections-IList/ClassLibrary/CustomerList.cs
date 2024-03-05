using System.Collections;
namespace ClassLibrary;

public class CustomerList : IList<Customer>
{
    private List<Customer> _customer = [];

    

    public Customer this[int index] { get => _customer[index]; set { _customer[index] = value; } }

    public int Count => _customer.Count;

    public bool IsReadOnly => false;

    public void Add(Customer item)
    {
        _customer.Add(item);
    }

    public void Clear()
    {
        _customer.Clear();
    }

    public bool Contains(Customer item)
    {
        return _customer.Contains(item);
    }

    public void CopyTo(Customer[] array, int arrayIndex)
    {
        _customer.CopyTo(array, arrayIndex);
    }

    public IEnumerator<Customer> GetEnumerator()
    {
        foreach (var customer in _customer)
        {
            yield return customer;
        }
    }

    public int IndexOf(Customer item)
    {
        return _customer.IndexOf(item);
    }

    public void Insert(int index, Customer item)
    {
        _customer.Insert(index, item);
    }

    public bool Remove(Customer item) => _customer.Remove(item);

    public void RemoveAt(int index) => _customer.RemoveAt(index);

    IEnumerator IEnumerable.GetEnumerator() => _customer.GetEnumerator();
}