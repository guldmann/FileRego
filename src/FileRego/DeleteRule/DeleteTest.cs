using FileRego.Rules.Delete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeleteRule
{
    [TestClass]
    public class DeleteTest
    {
        [TestMethod]
        public void Whene_deleteText_is_used_correct_string_is_returned()
        {
            //Arrange
            const string fileName = "ThisIsafilename.txt";
            const string exspected = "Thisafilename.txt";

            //Act
            var result = fileName.DeleteText("Is");

            //Assert
            Assert.AreEqual(exspected, result);
        }

        [TestMethod]
        public void When_Extension_is_true_and_there_is_no_extension_this_is_handled_correct()
        {
            //Arrange
            const string fileName = "ThiIsFilenamewithtxt_no_extension";
            const string exspected = "ThiIsFilenamewith_no_extension";

            //Act
            var result = fileName.DeleteText("txt", false, false);

            //Assert
            Assert.AreEqual(exspected,result);
        }

        [TestMethod]
        public void When_Extension_is_deleted_this_is_handled_correct()
        {
            //Arrange
            const string fileName =  "ThiIsFilenamewithtxt.txt";
            const string exspected = "ThiIsFilenamewith.";

            //Act
            var result = fileName.DeleteText("txt", false, false);

            //Assert
            Assert.AreEqual(exspected, result);
        }
    }
}
