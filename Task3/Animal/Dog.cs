namespace Task3.Animal;

internal class Dog : Animal
{
    public string Breed { get; }

    internal Dog(
        string name,
        double weight,
        double age,
        string breed
        ) : base(name, weight, age)
    {
        Breed = breed;
    }

    internal override string DoSound()
    {
        return "Barking";
    }
}
