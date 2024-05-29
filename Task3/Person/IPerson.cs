using System.ComponentModel.DataAnnotations;

namespace Task3.Person;

/// <summary>
/// A interface used to describe a domain person.
/// </summary>
internal interface IPerson
{
    int Age { get; set; }

    string FName { get; set; }

    string LName { get; set; }
    
    double Height { get; set; }
    
    double Weight { get; set; }
}