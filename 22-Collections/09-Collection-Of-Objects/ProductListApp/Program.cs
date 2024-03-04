using ClassLibrary;

class Program
{
    private static List<Product> products = [];

    static void Main() {
        int choice = -1;
        while (true)
        {
            Console.WriteLine("=== Menu ===\n");
            Console.WriteLine("1. Add Product(s)");
            Console.WriteLine("2. See Products");
            Console.WriteLine("\n0. Exit\n");
            Console.WriteLine("============\n");

            Console.Write("Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                AddProducts();
                break;

                case 2:
                DisplayProduct();
                break;

                default:
                return;
            }

        }

    }

    static void AddProducts() {
        String choice = "";
        do
        {
            Console.WriteLine("\nNew Product\n");
            Console.Write("Product Name: ");
            String productName = Console.ReadLine() ?? "** Not Provided **";
            
            Console.Write("Product Price: ");
            double price = Convert.ToDouble(
                Console.ReadLine()
            );

            products.Add(
                new Product(productName, price)
            );

            Console.Write("Want to continue ? (y/n): ");
            choice = Console.ReadLine() ?? "n";
            choice = choice.ToLower();
        } while (!choice.StartsWith('n'));
    }

    static void DisplayProduct() {
        Console.WriteLine("Displaying products: ");
        foreach (Product item in products)
        {
            Console.WriteLine($"{item.Id}. {item.Name} Rs.{item.Price}");
        }
    }

}