class Program
{
    static void Main() {
        int counter = 10;

        // While Loop
        while (counter > 0)
        {
            Console.WriteLine("Counter: " + counter);
            counter --;
        }

        // Do While
        do
        {
            Console.WriteLine("Counter :" + counter);
            counter++;
        } while (counter < 10);


        // For Loop
        for (int forCounter=0; forCounter <= 10; forCounter++) {
            Console.WriteLine("Counter: "+ forCounter);
            // Break Statement
            if (forCounter == 5)
            {
                break;
            }
        }

        // For Loop with Continue Keyword
        for (int anotherCounter = 0; anotherCounter < 10; anotherCounter++)
        {
            if (anotherCounter == 5)
            {
                continue; // Rest of loop will be skipped;(Counter: 5 will be skipped)
            }

            Console.WriteLine("Counter: " + anotherCounter);

        }
        
        // Nested For Loop
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
} 