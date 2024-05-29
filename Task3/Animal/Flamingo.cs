using System.Text;
using Task3.Lib;

namespace Task3.Animal;

internal class Flamingo : Bird
{
    public double LegLength { get; }

    internal Flamingo(
        string name,
        double weight,
        double age,
        double wingSpan,
        double legLength) : base(name, weight, age, wingSpan)
    {
        LegLength = legLength;
    }

    internal override string DoSound()
    {
        return "Nasal honking to grunting or growling";
    }

    internal override string Stats()
    {
        var baseStats = base.Stats();
        var stringBuilder = new StringBuilder(baseStats);
        stringBuilder.AppendLine($"{nameof(LegLength)}: {LegLength}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }
}
