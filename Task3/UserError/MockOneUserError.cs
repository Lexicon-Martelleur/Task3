namespace Task3.UserError;

internal class MockOneUserError : UserError
{
    internal override string UEMessage()
    {
        return $"{this.GetType().FullName} error message.";
    }
}
