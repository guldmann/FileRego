//TODO: Implement casesensitive
namespace FileRego.Rules.Delete
{
    public static class DeleteTextRule
    {
        public static string DeleteText(
            this string fileName,
            string deleteString,
            bool skipExtension = true ,
            bool caseSensitive = false)
        {
            string extension = "";
            if (skipExtension)
            {
                fileName = fileName.SplitExtension(out extension);
            }
            return fileName.Replace(deleteString, "") + extension;
        }
    }
}