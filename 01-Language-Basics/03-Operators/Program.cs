class OperatorDemo {
    static void Main() {
        String name = "Suyash Lawand";
        int age = 25;
        bool isAdult = age > 18;

        if (isAdult)
        {
            Console.WriteLine(name + " is Adult");
        }

        // logical operator
        String[] names = name.Split(" ");
        if (name.Equals(names[0]) && age > 18)
        {
            Console.WriteLine("Suyash is an adult");
        }
    }
}