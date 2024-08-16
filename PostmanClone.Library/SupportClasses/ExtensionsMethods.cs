using System.Text.Json;

namespace PostmanClone.Library.SupportClasses;

internal static class ExtensionsMethods
{
    public static bool IsJson(this string source)
    {
        if (source == null)
            return false;

        try
        {
            using JsonDocument doc = JsonDocument.Parse(source);
            return true;
        }
        catch (JsonException)
        {
            return false;
        }
    }
}
