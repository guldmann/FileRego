using FileRego.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeleteRuleTests
{
    [TestClass]
    public class DeleteTest
    {
        [TestMethod]
        public void Whene_deleteText_is_used_correct_string_is_returned()
        {
            //Arrange
            var fileName = "ThisIsafilename.txt";
            var exspected = "Thisafilename.txt";

            //Act
            var result = fileName.DeleteText("Is");

            //Assert
            Assert.AreEqual(exspected, result);
        }

        [TestMethod]
        public void When_Extension_is_true_and_there_is_no_extension_this_is_handled_correct()
        {
            //Arrange
            var fileName = "ThiIsFilenamewithtxt_no_extension";
            var exspected = "ThiIsFilenamewith_no_extension";

            //Act
            var result = fileName.DeleteText("txt", false, false);

            //Assert
            Assert.AreEqual(exspected,result);
        }

        [TestMethod]
        public void When_Extension_is_deleted_this_is_handled_correct()
        {
            //Arrange
            var fileName =  "ThiIsFilenamewithtxt.txt";
            var exspected = "ThiIsFilenamewith.";

            //Act
            var result = fileName.DeleteText("txt", false, false);

            //Assert
            Assert.AreEqual(exspected, result);
        }

    }
}
