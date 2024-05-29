namespace Task3.Lib;

/// <summary>
/// Utility class used for string extensions.
/// </summary>
public static class StringExtensions
{
    public static string ConstructArrowListItem(this string text)
    {
        return $"\t➡️ {text}";
    }

    public static string ConstructArrowListItem(this string text, string description)
    {
        return $"\t➡️ {description}: {text}";
    }
}
