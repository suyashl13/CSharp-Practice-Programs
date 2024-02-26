namespace ClassLibrary;

public class Warrior : Character
{
    public Warrior(string name, int health, int attack, int defense) 
        : base(name, health, attack, defense)
    {
    }

    public void Charge(Character target) {
        Console.WriteLine($"{this.name} charges at {target.name}");
    }

    sealed public override void Defend() {
        base.Defend();
        this.defense += 5;
    }
}