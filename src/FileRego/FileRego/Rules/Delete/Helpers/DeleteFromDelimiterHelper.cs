using System;

namespace FileRego.Rules.Delete.Helpers
{
    public static class DeleteFromDelimiterHelper
    {
        public static string DeleteFromDelimiterToDelimiter(
            this string text,
            string fromDelimiter,
            string toDelimiter,
            bool skipDelimiter,
            bool skipExtension = true)
        {
            if (string.IsNullOrEmpty(text)) return null;
            if (!text.Contains(fromDelimiter) || !text.Contains(toDelimiter))
            {
                return text;
            }

            var extension = "";
            if (skipExtension)
            {
                text = text.SplitExtension(out extension);
            }

            var indexOfFromDelimiter = text.IndexOf(fromDelimiter, StringComparison.Ordinal);
            var indexOfToDelimiter = text.IndexOf(toDelimiter, StringComparison.Ordinal);
            if (indexOfToDelimiter < indexOfFromDelimiter) return text;
            if (skipDelimiter)
            {
                indexOfFromDelimiter += fromDelimiter.Length;
                return text.Substring(0, indexOfFromDelimiter) + text.Substring(indexOfToDelimiter) + extension;
            }

            return text.Substring(0, indexOfFromDelimiter) + text.Substring(indexOfToDelimiter + toDelimiter.Length) +
                   extension;
        }


        public static string DeleteFromDelimiterToCount(
            this string text,
            string delimiter,
            int count,
            bool skipDelimiter,
            bool skipExtension = true)
        {
            if (string.IsNullOrEmpty(text)) return null;
            if (!text.Contains(delimiter)) return text;
            if (count > text.Length) return text;
            if (count < 1) return text;
            if (string.IsNullOrEmpty(delimiter)) return text;

            var indexOfDelimiter = text.IndexOf(delimiter, StringComparison.Ordinal);

            if ((indexOfDelimiter + count) > text.Length) return text;

            var extension = "";
            if (skipExtension)
            {
                text = text.SplitExtension(out extension);
            }

            if (skipDelimiter)
            {
                indexOfDelimiter += delimiter.Length;
                return text.Substring(0, indexOfDelimiter) + text.Substring(indexOfDelimiter + count) + extension;
            }
            return text.Substring(0, indexOfDelimiter) + text.Substring(indexOfDelimiter + delimiter.Length + count) + extension;

        }

        public static string DeleteFromDelimiterToEnd(
            this string text,
            string delimiter,
            bool skipDelimiter,
            bool skipExtension = true)
        {
            if (string.IsNullOrEmpty(text)) return null;
            if (string.IsNullOrEmpty(delimiter)) return text;
            if (!text.Contains(delimiter)) return text;

            var extension = "";
            if (skipExtension)
            {
                text = text.SplitExtension(out extension);
            }

            var indexOfDelimiter = text.IndexOf(delimiter, StringComparison.Ordinal);
            if (skipDelimiter)
            {
                indexOfDelimiter += delimiter.Length;
            }

            return text.Substring(0, indexOfDelimiter) + extension;
        }
    }
}