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
    }
}
