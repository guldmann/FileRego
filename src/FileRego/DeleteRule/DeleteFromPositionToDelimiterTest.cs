using System;
using FileRego.Rules.Delete;
using FileRego.Rules.Delete.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeleteRule
{
    [TestClass]
    public class DeleteFromPositionToDelimiterTest
    {
        [TestMethod]
        public void When_text_dont_contain_delimiter_original_string_is_returned()
        {
            //Arrange
            const string text = "ThisIsTheFileName.txt";
            const string expected = "ThisIsTheFileName.txt";

            //Act
            var result = text.DeleteFromPositionToDelimiter(0, "ABC", true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_text_is_null_null_is_returned()
        {
            //Arrange
            const string text = null;
            const string expected = null;

            //Act
            var result = text.DeleteFromPositionToDelimiter(0, "ABC", true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_DeleteFromPosition_to_dilimiter_is_Called_correct_data_is_returned()
        {
            //Arrange
            const string text = "ThisIsTheFile-ABC-Name.txt";
            const string expected = "Name.txt";

            //Act
            var result = text.DeleteFromPositionToDelimiter(0, "-ABC-", true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_DeleteFromPosition_is_greater_then_string_length_original_string_is_returned()
        {
            //Arrange
            const string text = "ThisIsTheFile-ABC-Name.txt";
            const string expected = "ThisIsTheFile-ABC-Name.txt";

            //Act
            var result = text.DeleteFromPositionToDelimiter(40, "-ABC-", true);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_DeleteFromPosition_to_dilimiter_and_delimiter_is_not_deleted_correct_data_is_returned()
        {
            //Arrange
            const string text = "ThisIsTheFile-ABC-Name.txt";
            const string expected = "-ABC-Name.txt";

            //Act
            var result = text.DeleteFromPositionToDelimiter(0, "-ABC-", false);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_DeleteFromPosition_is_after_delimiter_original_string_is_returned()
        {
            //Arrange
            const string text = "File-ABC-Name.txt";
            const string expected = "File-ABC-Name.txt";

            //Act
            var result = text.DeleteFromPositionToDelimiter(7, "-ABC-", false);

            Assert.AreEqual(expected, result);
        }
    }
}
