class Car {
    private string[] _brandNames = ["BMW", "Skoda", "Honda", "Volkswagen", "Audi"];
    private String[] _names = ["One", "Two", "Three", "Four", "Five"];

    // Public Indexer
    public string this[int index] {
        get {
            return _brandNames[index];
        }
        set {
            _brandNames[index] = value;
        }
    }

    public string this[String index] {
        get {
            return _names[Array.IndexOf(_names, index)];
        }
        set {
            this._names[0] = value;
        }
    }
}


class Program
{
    static void Main() {
        Car gla8 = new Car();
        gla8[3] = "Volvo";
        Console.WriteLine(gla8[3]);
    }
}