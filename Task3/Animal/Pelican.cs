using System.Text;
using Task3.Lib;

namespace Task3.Animal;

internal class Pelican : Bird
{
    public double BeakSize { get; }

    internal Pelican(
        string name,
        double weight,
        double age,
        double wingSpan,
        double beakSize) : base(name, weight, age, wingSpan)
    {
        BeakSize = beakSize;
    }

    internal override string Stats()
    {
        var baseStats = base.Stats();
        var stringBuilder = new StringBuilder(baseStats);
        stringBuilder.AppendLine($"{nameof(BeakSize)}: {BeakSize}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }

    internal override string DoSound()
    {
        return "Low, brief grunts";
    }
}
