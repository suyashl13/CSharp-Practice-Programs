// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main() {
        int marks = 70;
        char gradeLetter;

        if (marks >= 85)
        {
            gradeLetter  = 'O';
        } else if (marks >= 65 && marks < 85)
        {
            gradeLetter = 'A';   
        } else if (marks >= 50 && marks < 60) {
            gradeLetter = 'B';
        } else if (marks >= 35 && marks < 50)
        {
            gradeLetter = 'C';
        } else gradeLetter = 'F';

        Console.Write("Marks: ");
        Console.Write(marks);
        
        // Nested If
        if (marks == 70)
        {
            if (gradeLetter == 'A') {
                Console.WriteLine("\nLoop worked correctly");
            }
        }

        switch (gradeLetter)
        {
            case ('O'):
            Console.WriteLine("Outstanding");
            break;

            case 'A':
            Console.Write("Good");
            break;

            case 'B':
            Console.WriteLine("Better");
            break;

            case 'C':
            Console.WriteLine("Average");
            break;

            case 'F':
            Console.WriteLine("Fail");
            break;

            default:
            Console.WriteLine("Outof Bound");
            break;
        }

    }
}
