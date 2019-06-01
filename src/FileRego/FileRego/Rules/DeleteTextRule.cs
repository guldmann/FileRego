//TODO: Handle casesensitive
namespace FileRego.Rules
{
    public static class DeleteTextRule
    {
        public static string DeleteText(
            this string fileName,
            string deleteString,
            bool skipExtension = true ,
            bool CaseSensitive = false)
        {
            string extension = "";
            if (skipExtension)
            {
                var dotIndex = fileName.LastIndexOf('.');
                extension = fileName.Substring(dotIndex);
                fileName = fileName.Substring(0, dotIndex);
            }

            return fileName.Replace(deleteString, "") + extension;
        }
    }
}