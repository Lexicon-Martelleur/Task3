using System.Text;
using Task3.Lib;
using PersonModule = Task3.Person;

namespace Task3.Animal;

internal class Dog : Animal
{
    internal string Breed { get; }

    internal PersonModule.IPerson? Owner { get; set; }

    internal Dog(
        string name,
        double weight,
        double age,
        string breed
        ) : base(name, weight, age)
    {
        Breed = breed;
    }

    internal override string DoSound()
    {
        return "Barking";
    }

    internal override string Stats()
    {
        var baseStats = base.Stats();
        var stringBuilder = new StringBuilder(baseStats);
        stringBuilder.AppendLine($"{nameof(Breed)}: {Breed}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }

    internal string GetOwnerAsString ()
    {
        return Owner?.ToString() ?? "";
    }
}
