using ClassLibrary;

class Mage : Character
{
    public Mage(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {
    }

    public void CastSpell(Character target) {
        Console.WriteLine($"{this.name} casts a spell at {target.name}");
    }

    public sealed override void Defend()
    {
        base.Defend();
    }
}