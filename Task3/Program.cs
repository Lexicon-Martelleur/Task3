﻿using Task3.Person;

var personHandler = new PersonHandler();
try
{
    List<IPerson> group = [
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