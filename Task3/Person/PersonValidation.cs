using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Const = Task3.Person.PersonConst;

namespace Task3.Person;

file class ValidationConst
{
    internal const string INSTANCE = "Person";
}

internal class AgeValidation : RangeAttribute
{
    internal AgeValidation() : base(Const.MIN_AGE, Const.MAX_AGE)
    {
        ErrorMessage = $"⚠️ Age of {ValidationConst.INSTANCE} must be in the interval [" +
            $"{Const.MIN_AGE}," +
            $"{Const.MAX_AGE}]";
    }
}

internal class FNameValidation : StringLengthAttribute
{
    internal FNameValidation() : base(Const.MAX_FNAME)
    {
        MinimumLength = Const.MIN_FNAME;
        ErrorMessage = $"⚠️ Length of {ValidationConst.INSTANCE} first name must be in the interval [" +
            $"{Const.MIN_FNAME}," +
            $"{Const.MAX_FNAME}]";
    }
}

internal class LNameValidation : StringLengthAttribute
{
    internal LNameValidation() : base(Const.MAX_LNAME)
    {
        MinimumLength = Const.MIN_LNAME;
        ErrorMessage = $"⚠️ Length of {ValidationConst.INSTANCE} last name must be in the interval [" +
            $"{Const.MIN_LNAME}," +
            $"{Const.MAX_LNAME}]";
    }
}
