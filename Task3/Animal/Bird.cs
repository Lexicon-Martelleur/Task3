using System.Text;
using Task3.Lib;

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
        return "E.g., chirping, whistling, croaking, and mocking.";
    }

    internal override string Stats()
    {
        var baseStats = base.Stats();
        var stringBuilder = new StringBuilder(baseStats);
        stringBuilder.AppendLine($"{nameof(WingSpan)}: {WingSpan}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }
}
