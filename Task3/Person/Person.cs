using System.ComponentModel.DataAnnotations;
using Task3.Lib;

namespace Task3.Person;

/// <summary>
/// A class to create validated instances of <see cref="IPerson"/>.
/// </summary>
public class Person : IPerson
{
    #region Private fields
    private int _age;

    private string _fName = string.Empty;

    private string _lName = string.Empty;

    private double _height;

    private double _weight;
    #endregion

    [AgeValidation]
    public int Age {
        get => _age;
        set => _age = AppValidator.IsValidProp(this, nameof(Age), value);
    }

    [Required]
    [FNameValidation]
    public string FName {
        get => _fName;
        set => _fName = AppValidator.IsValidProp(this, nameof(FName), value);
    }

    [Required]
    [LNameValidation]
    public string LName { 
        get => _lName;
        set => _lName = AppValidator.IsValidProp(this, nameof(LName), value);
    }

    public double Height { get => _height; set => _height = value; }

    public double Weight { get => _weight; set => _weight = value; }

    public Person(string fName, string lName)
    {
        FName = fName;
        LName = lName;
    }

    public override string ToString()
    {
        return $"""
        (FName = {FName}, LName = {LName}, Age = {Age}, Weight = {Weight}, Height = {Height})
        """;
    }
}
