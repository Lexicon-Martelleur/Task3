namespace Task3.Animal;

internal class Pelican : Bird
{
    public double BeakSize { get; }

    internal Pelican(
        string name,
        double weight,
        double age,
        double wingSpan,
        double beakSize) : base(name, weight, age, wingSpan)
    {
        BeakSize = beakSize;
    }
}
