using Task3.Lib;
using AnimalModule = Task3.Animal;
using PersonModule = Task3.Person;
using UserErrorModule = Task3.UserError;

var personHandler = new PersonModule.PersonHandler();
TaskEncapsulation();
TaskPolymorphism();
TaskMorePolymorphism1();
TaskMorePolymorphism2();
TaskMorePolymorphism3();

# region 3.1 Encapsulation
void TaskEncapsulation()
{
    try
    {
        List<PersonModule.IPerson> group = [
            personHandler.CreatePerson(20, "Jon", "Mayer", 185, 85),
            personHandler.CreatePerson(19, "Martin", "Mayer", 180, 80),
            personHandler.CreatePerson(15, "Lars", "Mayer", 160, 65),
            personHandler.CreatePerson(14, "Eric", "Mayer", 150, 55),
        ];

        Console.WriteLine("Writing data about persons".ConstructSectionTitle());
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
}
#endregion

# region 3.2 Polymorphism
void TaskPolymorphism()
{
    List<UserErrorModule.UserError> userErrors = [
        new UserErrorModule.TextInputError(),
        new UserErrorModule.NumericInputError(),
        new UserErrorModule.MockOneUserError(),
        new UserErrorModule.MockTwoUserError(),
        new UserErrorModule.MockThreeUserError()
    ];

    Console.WriteLine("Writing UEMessage from user errors types".ConstructSectionTitle());

    foreach (var userError in userErrors)
    {
        Console.WriteLine($"\n{userError.UEMessage()}");
    }
}
#endregion

#region 3.3 Inheritance
#endregion

#region 3.4 More Polymorphism

// 3.4.3-7
// Writing data about some animal listed in animals.
// Stats and DoSound use the most specific implementation for each animal. 
void TaskMorePolymorphism1()
{
    List<AnimalModule.Animal> someAnimals = [
        new AnimalModule.Bird("Bird", 1, 10, 10),
        new AnimalModule.Flamingo("Flamingo", 5, 10, 10, 100),
        new AnimalModule.Pelican("Pelican", 10, 10, 10, 100),
        new AnimalModule.Swan("Swan", 5, 10, 10, true),
        new AnimalModule.WolfMan("WolfMan", 100, 50, 10)
    ];

    Console.WriteLine("Writing data about some animal listed in animals".ConstructSectionTitle());
    foreach (var animal in someAnimals)
    {
        var stats = animal.Stats();
        var sounds = animal.DoSound().ConstructArrowListItem("Sound");
        if (animal is AnimalModule.IPerson)
        {
            var animalPerson = (AnimalModule.IPerson)animal;
            var phrase = animalPerson.Talk();
            var phraseListItem = $"\n{phrase?.ConstructArrowListItem()}";
            Console.WriteLine(stats + sounds + phraseListItem);
        }
        else
        {
            Console.WriteLine(stats + sounds);
        }
    }
}

// 3.4.8 and
// 3.4.9 Can not add type horse to a list of type dogs because they are not same type.
// A Horse type can not be converted to a Dog type.
//var horse = new Horse("Freja", 200, 5, true);
//dogs.Add(horse);
// 3.4.14 - 15
void TaskMorePolymorphism2()
{
    var dogs = new List<AnimalModule.Dog>()
    {
        new("Fido", 20, 1, "Flat")
        {
            Owner = personHandler.CreatePerson(30, "Jon", "Scott", 180, 80)
        },
        new("Lisa", 20, 1, "Flat"){
            Owner = personHandler.CreatePerson(30, "Lisa", "Scott", 180, 80)
        },
        new("Lassi", 20, 1, "Flat"){
            Owner = personHandler.CreatePerson(30, "Lars", "Scott", 180, 80)
        }
    };

    Console.WriteLine("Writing data about dogs".ConstructSectionTitle());
    foreach (var dog in dogs)
    {
        var stats = dog.Stats();
        var sounds = dog.DoSound().ConstructArrowListItem("Sound");
        var owner = $"\n{dog.GetOwnerAsString().ConstructArrowListItem("Owner")}";
        Console.WriteLine(stats + sounds + owner);
    }
}

// 3.4.10  Use List<Animal> to mix all animals in the list.
// 3.4.11-13
// Writing data about some animal listed in animals.
// Stats and DoSound use the most specific implementation for each animal. 
void TaskMorePolymorphism3()
{
    List<AnimalModule.Animal> allAnimals = [
    new AnimalModule.Bird("Bird", 1, 10, 10),
    new AnimalModule.Dog("Dog", 1, 10, "Flat"),
    new AnimalModule.Flamingo("Flamingo", 5, 10, 10, 100),
    new AnimalModule.Hedgehog("Hedgehog", 5, 10, true),
    new AnimalModule.Horse("Horse", 100, 10, true),
    new AnimalModule.Pelican("Pelican", 10, 10, 10, 100),
    new AnimalModule.Swan("Swan", 5, 10, 10, true),
    new AnimalModule.Wolf("Wolf", 20, 10, 10),
    new AnimalModule.WolfMan("WolfMan", 100, 50, 10),
    new AnimalModule.Worm("WolfMan", 1, 50, true)
];

    Console.WriteLine("Writing data about all animal listed in animals".ConstructSectionTitle());
    foreach (var animal in allAnimals)
    {
        var stats = animal.Stats();
        var sounds = animal.DoSound().ConstructArrowListItem("Sound");
        if (animal is AnimalModule.IPerson)
        {
            var animalPerson = (AnimalModule.IPerson)animal;
            var phrase = animalPerson.Talk();
            var phraseListItem = $"\n{phrase?.ConstructArrowListItem()}";
            Console.WriteLine(stats + sounds + phraseListItem);
        }
        else
        {
            Console.WriteLine(stats + sounds);
        }
    }

}
# endregion
