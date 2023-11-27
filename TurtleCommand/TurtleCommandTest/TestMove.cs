using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleCommand;

namespace TurtleCommandTest
{
    [TestClass]
    public class TestMove
    {
        [TestMethod]
        public void MoveThreeTimesEast()
        {
            TurtleActions Turtle = new TurtleActions {direction = "east"};

            Turtle.Move();
            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(3, Turtle.east);
        }

        [TestMethod]
        public void MoveFourTimesEast()
        {
            TurtleCommand.TurtleActions Turtle = new TurtleCommand.TurtleActions { direction = "east"};

            Turtle.Move();
            Turtle.Move();
            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(4, Turtle.east);
        }

        [TestMethod]
        public void MoveThreeTimesWest()
        {
            TurtleActions Turtle = new TurtleActions {direction = "west"};

            Turtle.Move();
            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(-3, Turtle.east);
        }

        [TestMethod]
        public void MoveFourTimesWest()
        {
            TurtleActions Turtle = new TurtleActions { direction = "west" };

            Turtle.Move();
            Turtle.Move();
            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(-4, Turtle.east);
        }

        [TestMethod]
        public void MoveTwoTimesNorth()
        {
            TurtleActions Turtle = new TurtleActions { direction = "north" };

            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(3, Turtle.north);
        } 

        [TestMethod]
        public void MoveFourTimesSouth()
        {
            TurtleActions Turtle = new TurtleActions { direction = "south" };

            Turtle.Move();
            Turtle.Move();
            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(-4, Turtle.north);
        }  

        [TestMethod]
        public void WhenFacingEastTurnLeft()
        {
            TurtleActions Turtle = new TurtleActions { direction = "east" };

            Turtle.TurnLeft();

            Assert.AreEqual("north", Turtle.direction);
        }  

        [TestMethod]
        public void WhenFacingSouthTurnRight()
        {
            TurtleActions Turtle = new TurtleActions { direction = "south" };

            Turtle.TurnRight();

            Assert.AreEqual("west", Turtle.direction);
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
