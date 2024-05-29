using System.Text;
using Task3.Lib;

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

    internal override string Stats()
    {
        var baseStats = base.Stats();
        var stringBuilder = new StringBuilder(baseStats);
        stringBuilder.AppendLine($"{nameof(RunningSpeed)}: {RunningSpeed}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }
}
