using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MarsRoversAssessment.Test
{
    [TestClass]
    public class MovementTest
    {
        [TestMethod]
        public void FirstExampleMovement()
        {
            var position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };
            
            var maxCoordinates = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            var currentPosition = $"{position.X} {position.Y} {position.Direction.ToString()}";

            position.DoTheMovement(maxCoordinates, moves);

            var afterMovementPosition = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedPosition = "1 3 N";

            Assert.AreEqual(expectedPosition, afterMovementPosition);
            Assert.AreNotEqual(currentPosition, afterMovementPosition);
        }

        [TestMethod]
        public void SecondExampleMovement()
        {
            var position = new Position()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var maxCoordinates = new List<int>() { 5, 5 };
            var moves = "MMRMMRMRRM";

            var currentPosition = $"{position.X} {position.Y} {position.Direction.ToString()}";

            position.DoTheMovement(maxCoordinates, moves);

            var afterMovementPosition = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedPosition = "5 1 E";

            Assert.AreEqual(expectedPosition, afterMovementPosition);
            Assert.AreNotEqual(currentPosition, afterMovementPosition);
        }

        [TestMethod]
        public void NoMovementExample()
        {
            var position = new Position()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var maxCoordinates = new List<int>() { 5, 5 };
            var moves = "";

            var currentPosition = $"{position.X} {position.Y} {position.Direction.ToString()}";

            position.DoTheMovement(maxCoordinates, moves);

            var afterMovementPosition = $"{position.X} {position.Y} {position.Direction.ToString()}";
            
            Assert.AreEqual(currentPosition, afterMovementPosition);
        }
    }
}
