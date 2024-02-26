using ClassLibrary;

public class Game
{
    public static void Main(string[] args)
    {
        Warrior arthur = new Warrior("Arthur", 100, 20, 15);
        Mage merlin = new Mage("Merlin", 80, 10, 10);
        Dragon smaug = new Dragon("Smaug", 200, 40, 30);

        Console.WriteLine($"{arthur.name} is a warrior.");
        Console.WriteLine($"{merlin.name} is a mage.");
        Console.WriteLine($"{smaug.name} is a dragon.\n");

        arthur.Attack(merlin);
        merlin.Defend();
        smaug.BreatheFire(arthur);
        arthur.Defend();
        smaug.Defend();
        Console.WriteLine("--- Battle between Arthur and Merlin ---");
        Console.WriteLine("Merlin wins!");
        Console.WriteLine("--- Battle between Smaug and Arthur ---");
        Console.WriteLine("Smaug wins!");
        Console.WriteLine("--- Battle between Merlin and Smaug ---");
        merlin.Attack(smaug);
        smaug.Attack(merlin);
        merlin.Attack(smaug);
        smaug.Attack(merlin);
        smaug.Attack(merlin);
        Console.WriteLine("Smaug wins!");
    }
}