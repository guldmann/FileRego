namespace FileRego.Rules.Delete
{
    public static class DeleteFromPositionRule
    {
        public static string DeleteFromToPosition(
            this string fileName,
            int fromPosition,
            int toPosition,
            bool skipExtension = true)
        {
            var extension = "";
            if (skipExtension)
            {
                fileName = fileName.SplitExtension(out extension);
            }
            if (toPosition > fromPosition && toPosition < fileName.Length)
            {
                var firstPart = fileName.Substring(0, fromPosition);
                if (toPosition > fileName.Length && fromPosition + toPosition > fileName.Length)
                {
                    return firstPart + extension;
                }
                return firstPart + fileName.Substring(toPosition) + extension;
            }
            return fileName + extension;
        }

        public static string DeleteFromPositionToTheEnd(
            this string fileName,
            int fromPosition,
            bool skipExtension = true)
        {
            if (string.IsNullOrEmpty(fileName)) return fileName;

            var extension = "";
            if (skipExtension)
            {
                fileName = fileName.SplitExtension(out extension);
            }
            return fileName.Substring(0, fromPosition) + extension;
        }

        public static string DeleteFromPositionToCount(
            this string fileName,
            int fromPosition,
            int numChar,
            bool skipExtension)
        {
            if (string.IsNullOrEmpty(fileName)) return null;
            if (fromPosition + numChar > fileName.Length) return fileName;

            var extension = "";
            if (skipExtension)
            {
                fileName = fileName.SplitExtension(out extension);
            }

            var firstPart = fileName.Substring(0, fromPosition);

            return firstPart + fileName.Substring(fromPosition + numChar) + extension;
        }
    }
}
