using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileRego.Rules.Delete.Helpers;

namespace FileRego.Rules.Delete
{
    public class DeleteRule : BaseRule
    {
        public bool FromPosition { get; set; }
        public int FromPositionNumber { get; set; }
        public bool ToPosition { get; set; }
        public int ToPositionNumber { get; set; }
        public bool FromDelimiter { get; set; }
        public string FromDelimiterText { get; set; }
        public bool ToDilimiter { get; set; }
        public string ToDilimiterText { get; set; }
        public bool ToCount { get; set; }
        public int ToCountNumber { get; set; }
        public bool ToTheEnd { get; set; }
        public bool SkipExtension { get; set; }
        public bool DoNotRemoveDelimiter { get; set; }
        public string TextToDelete { get; set; }
        public bool DeleteText { get; set; }
        public bool DeleteFromPositionToCount { get; set; }
        public bool DeleteFromPositionToTheEnd { get; set; }
        public bool DeleteFromPositionToDelimiter { get; set; }
        public bool DeleteFromToPosition { get; set; }

        //public override string Apply(string text)
        //{
        //    if (DeleteText)
        //    {
        //        return text.DeleteText(TextToDelete, SkipExtension);
        //    }

        //    if (DeleteFromPositionToCount)
        //    {
        //        return text.DeleteFromPositionToCount(FromPositionNumber, ToCountNumber, SkipExtension);
        //    }

        //    if (DeleteFromPositionToTheEnd)
        //    {
        //        return text.DeleteFromPositionToTheEnd(FromPositionNumber, SkipExtension);
        //    }

        //    if (DeleteFromPositionToDelimiter)
        //    {

        //        return text.DeleteFromPositionToDelimiter(FromPositionNumber, ToDilimiterText, DoNotRemoveDelimiter,
        //            SkipExtension);
        //    }

        //    if (DeleteFromToPosition)
        //    {
        //        return text.DeleteFromToPosition(FromPositionNumber, ToPositionNumber, SkipExtension);
        //    }

        //    return null;

        //}
        public override string Apply(string text)
        {
            if (DeleteText)
            {
                return DeleteTheText(text);
            }

            if (FromDelimiter)
            {
                return DeleteFromDelimiter(text);
            }

            if (FromPosition)
            {
                //return DeleteFromPosition(text);
            }

            return null;
        }

        private string DeleteFromDelimiter(string text)
        {
            if (ToDilimiter)
            {

            }

            if (ToCount)
            {

            }

            if (ToPosition)
            {

            }

            if (ToTheEnd)
            {

            }

            return text;
        }

        private string DeleteTheText(string text)
        {
            return text.DeleteText(TextToDelete, SkipExtension);
        }
    }
}
