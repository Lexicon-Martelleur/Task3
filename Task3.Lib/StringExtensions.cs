using System.Text;

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

    public static string ConstructSectionTitle(this string sectionTitle)
    {
        var title = $"📝📝📝 --- {sectionTitle} --- 📝📝📝\n";
        var titleLength = title.Length;
        var line = new StringBuilder("=");
        for (int i = 0; i < titleLength; i++)
        {
            line.Append("=");
        }
        line.Append("\n");
        return "\n" + line.ToString() + title + line.ToString();
    }
}
