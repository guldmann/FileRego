
namespace FileRego.Rules
{
    public static class RuleHelper
    {
        public static string SplitExtension(this string text, out string extensionPart)
        {
            extensionPart = "";
            if (string.IsNullOrEmpty(text)) return null;
            var dotIndex = text.LastIndexOf('.');
            extensionPart = text.Substring(dotIndex);
            return text.Substring(0, dotIndex);
        }
    }
}
