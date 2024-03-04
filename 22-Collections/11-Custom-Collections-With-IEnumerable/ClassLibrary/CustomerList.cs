using System.Collections  ;

namespace ClassLibrary;

public class CustomerList : IEnumerable
{   
    private readonly List<Customer> _customerList = new();

    public void Add(Customer customer) {
        this._customerList.Add(customer);
    }

    public void Remove(Customer customer) {
        this.Remove(customer);
    }

    public IEnumerator GetEnumerator()
    {
        for (int index = 0; index < _customerList.Count; index++)
        {
            yield return _customerList[index];
        }
    }
}