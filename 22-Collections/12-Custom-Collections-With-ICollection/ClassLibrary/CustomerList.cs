using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary;

public class CustomerList : ICollection<Customer>
{
    // Private collection as a field
    private readonly List<Customer> _customerList = new List<Customer>();

    public int Count => _customerList.Count;

    public bool IsReadOnly => false;

    public void Add(Customer item)
    {
        _customerList.Add(item);
    }

    public void Clear()
    {
        _customerList.Clear();
    }

    public bool Contains(Customer item)
    {
        return _customerList.Contains(item);
    }

    public void CopyTo(Customer[] array, int arrayIndex)
    {
        this._customerList.CopyTo(array, arrayIndex);
    }

    public IEnumerator<Customer> GetEnumerator()
    {
        return this._customerList.GetEnumerator();
    }

    public bool Remove(Customer item)
    {
        return this._customerList.Remove(item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this._customerList.GetEnumerator();
    }
}