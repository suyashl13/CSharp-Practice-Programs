class Program
{

    // Execution Starts Here
    static void Main()
    {
        // Display Title
        Console.WriteLine("--------------- Banking Application ---------------");
        Console.WriteLine("::Login Page::");

        // Variables to Store Credentials
        String userName = null;
        String password = null;

        // Read Username from console;
        Console.Write("Username: ");
        userName = Console.ReadLine();

        if (userName != "")
        {
            // Read password from console;
            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        // Validate the user
        if (userName == "john" && password == "admin")
        {
            int? mainMenuChoice = null;
            do
            {
                Console.WriteLine("TODO Menu");
                Console.WriteLine("---------------------------");
                Console.WriteLine();
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit\n");

                Console.Write("Enter your choice: ");
                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;

                    case 2:
                        AccountsMenu();
                        break;

                    case 3:
                    break;

                    default:
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            Console.WriteLine("Invalid Username or Password");
        }

        Console.WriteLine("Thank you visit again");
        Console.ReadLine();
    }

    static void CustomersMenu()
    {
        // Variable to store customer choice.
        int customerChoice = -1;

        do
        {
            Console.WriteLine("\n::Customer Menu::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customer");
            Console.WriteLine("0. Back to Main Menu");

            Console.Write("Enter your choice: ");
            customerChoice = int.Parse(Console.ReadLine());
        } while (customerChoice != 0);

    }

    static void AccountsMenu()
    {
        // Variable to store customer choice.
        int accMenuChoice = -1;

        do
        {
            Console.WriteLine("\n::Customer Menu::");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Update Account");
            Console.WriteLine("4. View Account");
            Console.WriteLine("0. Back to Main Menu");

            Console.Write("Enter your choice: ");
            accMenuChoice = int.Parse(Console.ReadLine());
        } while (accMenuChoice != 0);

    }

}