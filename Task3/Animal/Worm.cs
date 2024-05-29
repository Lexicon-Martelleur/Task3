namespace Task3.Animal;

internal class Worm : Animal
{
    public bool Poisonous { get; }

    internal Worm(
        string name,
        double weight,
        double age,
        bool poisonous
        ) : base(name, weight, age)
    {
        Poisonous = poisonous;
    }

    internal override string DoSound()
    {
        return "Silent";
    }
}
