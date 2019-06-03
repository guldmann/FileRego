using System;
using FileRego.Rules.Delete.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeleteRule
{
    [TestClass]
    public class DeleteFromDelimiter
    {
        [TestMethod]
        public void When_delete_from_delimiter_to_delimiter_keep_delimiter_correct_data_is_returned()
        {
            const string text = "This:isAString123NameText.txt";
            const string expected = "This:123NameText.txt";
            var result = text.DeleteFromDelimiterToDelimiter(":", "123", true, true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_delete_from_delimiter_to_delimiter_delete_delimiter_correct_data_is_returned()
        {
            const string text = "This:isAString123NameText.txt";
            const string expected = "ThisNameText.txt";
            var result = text.DeleteFromDelimiterToDelimiter(":", "123", false);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_delete_from_delimiter_to_delimiter_and_delimiter_is_missing_in_text_correct_data_is_returned()
        {
            const string text = "This:isAString123NameText.txt";
            const string expected = "This:isAString123NameText.txt";
            var result = text.DeleteFromDelimiterToDelimiter(":", ";;", false);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_delete_from_delimiter_to_count_delete_delimiter_correct_data_is_returned()
        {
            const string text =     "ThisABCisAString123NameText.txt";
            const string expected = "Thisring123NameText.txt";
            var result = text.DeleteFromDelimiterToCount("ABC", 5, false);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_delete_from_delimiter_to_count_keep_delimiter_correct_data_is_returned()
        {
            const string text = "ThisABCisAString123NameText.txt";
            const string expected = "ThisABCring123NameText.txt";
            var result = text.DeleteFromDelimiterToCount("ABC", 5, true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_delete_from_delimiter_to_count_and_delete_is_longer_then_string_correct_data_is_returned()
        {
            const string text = "ThisABCisAString123NameText.txt";
            const string expected = "ThisABCisAString123NameText.txt";
            var result = text.DeleteFromDelimiterToCount("ABC", 50, true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_delete_from_delimiter_to_end_and_keep_delimiter_then_string_correct_data_is_returned()
        {
            const string text = "ThisABCisAString123NameText.txt";
            const string expected = "ThisABCisAString123.txt";
            var result = text.DeleteFromDelimiterToEnd("123", true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_delete_from_delimiter_to_end_and_delete_delimiter_then_string_correct_data_is_returned()
        {
            const string text = "ThisABCisAString123NameText.txt";
            const string expected = "ThisABCisAString.txt";
            var result = text.DeleteFromDelimiterToEnd("123", false);

            Assert.AreEqual(expected, result);
        }
    }
}
