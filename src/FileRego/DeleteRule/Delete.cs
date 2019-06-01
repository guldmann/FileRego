using System;
using FileRego.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeleteRule
{
    [TestClass]
    public class Delete
    {
        [TestMethod]
        public void Whene_deleteText_is_used_correct_string_is_returned()
        {
            var fileName = "ThisIsafilename.txt";
            var exspected = "Thisafilename.txt";
            var result = fileName.DeleteText("Is");

            Assert.AreEqual(result, exspected);
        }
    }
}
