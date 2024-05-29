namespace Task3.Animal;

internal class Horse : Animal
{
    public bool WildHorse { get; }

    internal Horse(
        string name,
        double weight,
        double age,
        bool wildHorse
        ) : base(name, weight, age)
    {
        WildHorse = wildHorse;
    }

    internal override string DoSound()
    {
        return "Neighs";
    }
}
