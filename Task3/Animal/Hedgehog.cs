namespace Task3.Animal;

internal class Hedgehog : Animal
{
    public bool Nocturnal { get; }

    internal Hedgehog(
        string name,
        double weight,
        double age,
        bool nocturnal
        ) : base(name, weight, age)
    {
        Nocturnal = nocturnal;
    }

    internal override string DoSound()
    {
        return "Grunting and snuffling";
    }
}
