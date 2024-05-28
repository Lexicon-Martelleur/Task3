using Task3;

try
{
    var p1 = new Person("Jon", "Mayer") { Age = 1 };
    Console.WriteLine($"""
        Person: {p1.FName} {p1.LName} age {p1.Age}
    """);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

