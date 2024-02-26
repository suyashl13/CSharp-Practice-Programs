using ClassLibrary;

class Dragon : Character
{
    public Dragon(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {
    }

    public sealed override void Attack(Character target)
    {
        base.Attack(target);
        this.attack *= 2; 
    }

    public void BreatheFire(Character target) {
        Console.WriteLine($"{this.name} breathes fire on {target.name}");
    }
}