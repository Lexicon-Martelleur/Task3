namespace Task3.UserError;

internal class MockTwoUserError : UserError
{
    internal override string UEMessage()
    {
        return $"{this.GetType().FullName} error message.";
    }
}
