using System.ComponentModel.DataAnnotations;

namespace Task3.Lib;

/// <summary>
/// Utility class used for validation.
/// </summary>
public static class AppValidator
{
    /// <summary>
    /// A utility method used to check the value of a property using the
    /// properties validation attributes.  
    /// </summary>
    /// <typeparam name="Value">The type of the property</typeparam>
    /// <param name="instance">The instance</param>
    /// <param name="prop">The name of the property</param>
    /// <param name="value">The value of the property</param>
    /// <returns name="Value"></returns>
    /// <exception cref="ArgumentException"></exception>
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

