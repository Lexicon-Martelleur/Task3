using System.Text;
using Task3.Lib;

namespace Task3.Animal;

internal class Swan : Bird
{
    public bool Dangerous { get; }

    internal Swan(
        string name,
        double weight,
        double age,
        double wingSpan,
        bool dangerous) : base(name, weight, age, wingSpan)
    {
        Dangerous = dangerous;
    }

    internal override string DoSound()
    {
        return "Growl, whistle and snort";
    }

    internal override string Stats()
    {
        var baseStats = base.Stats();
        var stringBuilder = new StringBuilder(baseStats);
        stringBuilder.AppendLine($"{nameof(Dangerous)}: {Dangerous}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }
}
