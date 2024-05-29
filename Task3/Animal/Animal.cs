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
}
