namespace Task3.Animal;

/// <summary>
/// Base class for birds.
/// </summary>
/// <remarks>Use this class to implement standard bird operations</remarks>
internal class Bird : Animal
{
    public double WingSpan { get; }

    internal Bird(
        string name,
        double weight,
        double age,
        double wingSpan
        ) : base(name, weight, age) {
        WingSpan = wingSpan;
    }

    internal override string DoSound()
    {
        return "Multiple sounds, e.g., chirping, whistling, croaking, and mocking.";
    }
}
