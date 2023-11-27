using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleCommand;

namespace TurtleCommandTest
{
    [TestClass]
    public class TestPlace
    {
        [TestMethod]
        public void ValidLocationsForFiveDimension()
        {
            TurtleCommand.Process table = new Process();
            
            Assert.IsTrue(table.IsValidLocation(0, 0), "(0, 0) is False");
            Assert.IsTrue(table.IsValidLocation(4, 4), "(4, 4) is False");
            Assert.IsFalse(table.IsValidLocation(5, 5), "(5, 5) is True");
            Assert.IsFalse(table.IsValidLocation(-1, -1), "(-1, -0) is True");
        }
    }
}
