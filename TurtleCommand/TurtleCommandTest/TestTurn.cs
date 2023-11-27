using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleCommand;

namespace TurtleCommandTest
{
    [TestClass]
    public class TestTurn
    {          

        [TestMethod]
        public void WhenFacingEastTurnLeft()
        {
            TurtleActions Turtle = new TurtleActions { direction = "east" };

            Turtle.TurnLeft();

            Assert.AreEqual("north", Turtle.direction);

        } 

        [TestMethod]
        public void WhenFacingWestTurnRight()
        {
            TurtleActions Turtle = new TurtleActions { direction = "west" };

            Turtle.TurnRight();

            Assert.AreEqual("north", Turtle.direction);

        }
    }
}
