namespace Task3.UserError;

internal class MockThreeUserError : UserError
{
    internal override string UEMessage()
    {
        return $"{this.GetType().FullName} error message.";
    }
}
