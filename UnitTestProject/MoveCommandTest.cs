using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRovers;

namespace UnitTestProject
{
    [TestClass]
    public class MoveCommandTest
    {
        [TestMethod]
        public void MoveCommand_Test()
        {
            // arrange
            Plateau plateau = new Plateau(5, 5);
            CommandParameter commandParameter = new CommandParameter(1, 3, 'N');
            CommandMove commandMove = new CommandMove();
            // act

            var result = commandMove.MoveCommandBorderControl(commandParameter, plateau);

            // assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void MoveCommand_Testv2()
        {
            // arrange
            Plateau plateau = new Plateau(5, 5);
            CommandParameter commandParameter = new CommandParameter(4, 3, 'E');
            CommandMove commandMove = new CommandMove();
            // act

            var result = commandMove.MoveCommandBorderControl(commandParameter, plateau);

            // assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void MoveCommand_North_Border_Test()
        {
            // arrange
            Plateau plateau = new Plateau(5, 5);
            CommandParameter commandParameter = new CommandParameter(1, 5, 'N');
            CommandMove commandMove = new CommandMove();
            // act

            var result = commandMove.MoveCommandBorderControl(commandParameter, plateau);
            
            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void MoveCommand_Testv3()
        {
            // arrange
            Plateau plateau = new Plateau(5, 5);
            CommandParameter commandParameter = new CommandParameter(4, 3, 'E');
            CommandMove commandMove = new CommandMove();
            // act

            var result = commandMove.MoveCommandBorderControl(commandParameter, plateau);

            // assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void MoveCommand_East_Border_Test()
        {
            // arrange
            Plateau plateau = new Plateau(5, 5);
            CommandParameter commandParameter = new CommandParameter(5, 3, 'E');
            CommandMove commandMove = new CommandMove();
            // act

            var result = commandMove.MoveCommandBorderControl(commandParameter, plateau);

            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void MoveCommand_South_Border_Test()
        {
            // arrange
            Plateau plateau = new Plateau(5, 5);
            CommandParameter commandParameter = new CommandParameter(3, 0, 'S');
            CommandMove commandMove = new CommandMove();
            // act

            var result = commandMove.MoveCommandBorderControl(commandParameter, plateau);

            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void MoveCommand_West_Border_Test()
        {
            // arrange
            Plateau plateau = new Plateau(5, 5);
            CommandParameter commandParameter = new CommandParameter(0, 5, 'W');
            CommandMove commandMove = new CommandMove();
            // act

            var result = commandMove.MoveCommandBorderControl(commandParameter, plateau);

            // assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void MoveCommand_WrongDirection_Test()
        {
            // arrange
            Plateau plateau = new Plateau(5, 5);
            CommandParameter commandParameter = new CommandParameter(4, 3, 'T');
            CommandMove commandMove = new CommandMove();
            // act

            var result = commandMove.MoveCommandBorderControl(commandParameter, plateau);

            // assert
            Assert.AreEqual(true, result);
        }

    }
}
