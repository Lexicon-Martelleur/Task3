using System.ComponentModel.DataAnnotations;

namespace Task3.Lib;

public static class AppValidator
{
    public static Value IsValidProp<Value>(
        object instance,
        string prop,
        Value value)
    {
        var context = new ValidationContext(instance) { MemberName = prop };
        var validations = new List<ValidationResult>();

        try
        {
            var isValid = Validator.TryValidateProperty(value, context, validations);
            return CheckValidationResult(isValid, validations, value);
        }
        catch
        {
            throw new ArgumentException($"Invalid property {prop} for {instance.GetType().FullName}");
        }
    }

    private static Value CheckValidationResult<Value>(
        bool isValid,
        List<ValidationResult> validations, 
        Value value)
    {
        if (!isValid)
        {
            foreach (var validationResult in validations)
            {
                throw new ArgumentException(
                    validationResult.ErrorMessage ?? $"Invalid prop value"
                );
            }
        }
        return value;
    }
}

