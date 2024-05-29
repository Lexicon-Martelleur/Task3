namespace Task3.Animal;

internal class Wolf : Animal
{
    public double RunningSpeed { get; }

    internal Wolf(
        string name,
        double weight,
        double age,
        double runningSpeed
        ) : base(name, weight, age)
    {
        RunningSpeed = runningSpeed;
    }

    internal override string DoSound()
    {
        return "Howling";
    }
}
