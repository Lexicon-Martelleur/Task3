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
}
