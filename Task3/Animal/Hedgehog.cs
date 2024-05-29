using System.Text;
using Task3.Lib;

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

    internal override string Stats()
    {
        var baseStats = base.Stats();
        var stringBuilder = new StringBuilder(baseStats);
        stringBuilder.AppendLine($"{nameof(Nocturnal)}: {Nocturnal}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }
}
