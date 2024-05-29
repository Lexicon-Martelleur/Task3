using Task3.Lib;
using AnimalModule = Task3.Animal;
using PersonModule = Task3.Person;
using UserErrorModule = Task3.UserError;

# region 3.1 Encapsulation
var personHandler = new PersonModule.PersonHandler();
try
{
    List<PersonModule.IPerson> group = [
        personHandler.CreatePerson(20, "Jon", "Mayer", 185, 85),
        personHandler.CreatePerson(19, "Martin", "Mayer", 180, 80),
        personHandler.CreatePerson(15, "Lars", "Mayer", 160, 65),
        personHandler.CreatePerson(14, "Eric", "Mayer", 150, 55),
    ];

    foreach (var person in group)
    {
        Console.WriteLine($"\n{personHandler.GetPersonPropertiesAsString(person)}");
        personHandler.SetAge(person, personHandler.GetAge(person) + 1);
        personHandler.SetHeight(person, personHandler.GetHeight(person) + 5);
        personHandler.SetWeight(person, personHandler.GetWeight(person) + 5);
        Console.WriteLine(personHandler.GetPersonPropertiesAsString(person));
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
#endregion

# region 3.2 Polymorphism
List<UserErrorModule.UserError> userErrors = [
    new UserErrorModule.TextInputError(),
    new UserErrorModule.NumericInputError(),
    new UserErrorModule.MockOneUserError(),
    new UserErrorModule.MockTwoUserError(),
    new UserErrorModule.MockThreeUserError()
];

foreach (var userError in userErrors)
{
    Console.WriteLine($"\n{userError.UEMessage()}");
}
#endregion

#region 3.3 Inheritance
#endregion

#region 3.4 More Polymorphism

List<AnimalModule.Animal> animals = [
    new AnimalModule.Bird("bird", 100, 10, 10),
    new AnimalModule.Swan("Swan", 100, 10, 10, true),
    new AnimalModule.Flamingo("Flamingo", 100, 10, 10, 100),
    new AnimalModule.Pelican("Pelican", 100, 10, 10, 100),
    new AnimalModule.WolfMan("WolfMan", 100, 10, 10)
];

foreach (var animal in animals)
{
    var stats = animal.Stats();
    var sounds = animal.DoSound().ConstructArrowListItem("Sound");
    if (animal is AnimalModule.IPerson)
    {
        var phrase = (animal as AnimalModule.IPerson)?.Talk();
        var phraseListItem = $"\n{phrase?.ConstructArrowListItem()}";
        Console.WriteLine(stats + sounds + phraseListItem);
    }
    else
    {
        Console.WriteLine(stats + sounds);
    }
}

# endregion
