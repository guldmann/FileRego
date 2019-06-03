
using System;

namespace FileRego.Rules.Delete.Helpers
{
    public static class DeleteToDelimiterHelper
    {
        public static string DeleteFromPositionToDelimiter(
            this string text,
            int fromPosition,
            string delimiter,
            bool deleteDelimiter,
            bool skipExtension = true)
        {
            if (string.IsNullOrEmpty(text)) return null;

            var extension = "";
            if (skipExtension)
            {
                text = text.SplitExtension(out extension);
            }

            var indexOfDelimiter = text.IndexOf(delimiter);

            if (indexOfDelimiter == -1) return text + extension;
            if (fromPosition >= indexOfDelimiter) return text + extension;
            if (fromPosition >= text.Length) return text + extension;

            var firstPart = text.Substring(0, fromPosition);
            if (deleteDelimiter)
            {
                indexOfDelimiter += delimiter.Length;
            }

            return firstPart + text.Substring(indexOfDelimiter) + extension;
        }
    }
}
