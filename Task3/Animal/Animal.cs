using System.Text;
using Task3.Lib;

namespace Task3.Animal;

/// <summary>
/// Base class for animals.
/// </summary>
/// <remarks>Use this class to implement standard animal operations</remarks>
internal abstract class Animal(string name, double weight, double age)
{
    internal string Name { get; } = name;
    
    internal double Weight { get; } = weight;
    
    internal double Age { get; } = age;

    internal abstract string DoSound();

    internal virtual string Stats()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"✅ Stats animal {this.GetType().Name}:");
        stringBuilder.AppendLine($"{nameof(Name)}: {Name}".ConstructArrowListItem());
        stringBuilder.AppendLine($"{nameof(Weight)}: {Weight}".ConstructArrowListItem());
        stringBuilder.AppendLine($"{nameof(Age)}: {Age}".ConstructArrowListItem());
        return stringBuilder.ToString();
    }
}
