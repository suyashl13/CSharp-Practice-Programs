using ClassLibrary;
using ExtensionNamespace; // Also we need to import the namespace where we've extended the class's functionality

class Program
{
    static void Main() {
        Product product = new Product() {
            Cost = 120, Discount = 55
        };
        Console.WriteLine(product.GetDiscountPlusFive());
    }
}