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
}
