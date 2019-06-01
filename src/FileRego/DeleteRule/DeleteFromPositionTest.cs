using FileRego.Rules.Delete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeleteRule
{
    [TestClass]
    public class DeleteFromPositionTest
    {
        [TestMethod]
        public void When_Delete_from_position_is_called_and_skipExtension_is_tru_correct_data_is_returned()
        {
            //Arrange
            const string fileName = "TheFileName.txt";
            const string expected = "Name.txt";

            //Act
            var result = fileName.DeleteFromToPosition(0, 7);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_Delete_from_position_is_called_and_ToPosition_is_higher_then_string_length_orginal_string_is_returned()
        {
            //Arrange
            const string fileName = "TheFileName.txt";
            const string expected = "TheFileName.txt";

            //Act
            var result = fileName.DeleteFromToPosition(0, 20);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_delete_fromPositioin_is_higer_then_toPosition_orginal_String_is_returned()
        {
            //Arrange
            const string fileName = "TheFileName.txt";
            const string expected = "TheFileName.txt";

            //Act
            var result = fileName.DeleteFromToPosition(8, 6);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void When_delete_fromPositioin_to_end_correct_data_is_returned()
        {
            //Arrange
            const string fileName = "TheFileName.txt";
            const string expected = "The.txt";

            //Act
            var result = fileName.DeleteFromPositionToTheEnd(3);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void When_delete_fromPositioin_to_end_and_extension_is_not_skiped_correct_data_is_returned()
        {
            //Arrange
            const string fileName = "TheFileName.txt";
            const string expected = "The";

            //Act
            var result = fileName.DeleteFromPositionToTheEnd(3,false);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
