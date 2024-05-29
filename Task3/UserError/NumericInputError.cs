namespace Task3.UserError;

internal class NumericInputError : UserError
{
    internal override string UEMessage()
    {
        return "You tried to use a numeric input in a text only field. This fired an error!";
    }
}
