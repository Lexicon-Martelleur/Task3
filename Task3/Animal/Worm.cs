using System.Text;
using Task3.Lib;

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

    internal override string Stats()
    {
        var baseStats = base.Stats();
        var stringBuilder = new StringBuilder(baseStats);
        stringBuilder.AppendLine($"{nameof(Poisonous)}: {Poisonous}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }
}
