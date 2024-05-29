using System.Text;
using Task3.Lib;

namespace Task3.Animal;

internal class Horse : Animal
{
    public bool WildHorse { get; }

    internal Horse(
        string name,
        double weight,
        double age,
        bool wildHorse
        ) : base(name, weight, age)
    {
        WildHorse = wildHorse;
    }

    internal override string DoSound()
    {
        return "Neighs";
    }

    internal override string Stats()
    {
        var baseStats = base.Stats();
        var stringBuilder = new StringBuilder(baseStats);
        stringBuilder.AppendLine($"{nameof(WildHorse)}: {WildHorse}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }
}
