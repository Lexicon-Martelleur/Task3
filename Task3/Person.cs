using System.ComponentModel.DataAnnotations;

namespace Task3;

internal class Person
{
    #region Private fields
    private int _age;

    private string _fName = string.Empty;

    private string _lName = string.Empty;

    private double _height;

    private double _weight;
    #endregion

    [AgeValidation]
    public int Age { get => _age; set => _age = IsValid(nameof(Age), value); }

    [Required]
    [FNameValidation]
    public string FName { get => _fName; set => _fName = IsValid(nameof(FName), value); }

    [Required]
    [LNameValidation]
    public string LName { get => _lName; set => _lName = IsValid(nameof(LName), value); }

    public double Height { get => _height; set => _height = value; }
    
    public double Weight { get => _weight; set => _weight = value; }

    internal Person(string fName, string lName)
    {
        FName = fName;
        LName = lName;
    }

    private Value IsValid<Value>(string propName, Value value)
    {
        var context = new ValidationContext(this) { MemberName = propName };
        var validations = new List<ValidationResult>();
        var isValid = Validator.TryValidateProperty(value, context, validations);

        if (!isValid)
        {
            foreach (var validationResult in validations)
            {
                throw new ArgumentException(
                    validationResult.ErrorMessage ?? "Invalid property value"
                );
            }
        }
        return value;
    }

    internal static class Const 
    {
        internal const uint MIN_AGE = 1;
        internal const uint MAX_AGE = uint.MaxValue;
        internal const int MIN_FNAME = 2;
        internal const int MAX_FNAME = 10;
        internal const int MIN_LNAME = 3;
        internal const int MAX_LNAME = 15;
    }

    # region Custom validation attributes  
    private class AgeValidation : RangeAttribute
    {
        internal AgeValidation() : base(Const.MIN_AGE, Const.MAX_AGE)
        {
            ErrorMessage = $"Age must be in the interval [" +
                $"{Const.MIN_AGE}," +
                $"{Const.MAX_AGE}]";
        }
    }

    private class FNameValidation : StringLengthAttribute
    {
        internal FNameValidation() : base(Const.MAX_FNAME)
        {
            MinimumLength = Const.MIN_FNAME;
            ErrorMessage = $"First name must be in the interval [" +
                $"{Const.MIN_FNAME}," +
                $"{Const.MAX_FNAME}]";
        }
    }

    private class LNameValidation : StringLengthAttribute
    {
        internal LNameValidation() : base(Const.MAX_LNAME)
        {
            MinimumLength = Const.MIN_LNAME;
            ErrorMessage = $"Last name must be in the interval [" +
                $"{Const.MIN_LNAME}," +
                $"{Const.MAX_LNAME}]";
        }
    }
    #endregion
}
