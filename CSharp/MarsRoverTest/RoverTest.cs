using NUnit.Framework;

namespace MarsRover
{
    public class RoverTest
    {
        [TestCase('N', new[] {5, 5}, new[] {5, 6})]
        [TestCase('S', new[] {5, 5}, new[] {5, 4})]
        [TestCase('E', new[] {5, 5}, new[] {6, 5})]
        [TestCase('W', new[] {5, 5}, new[] {4, 5})]
        public void MoveRoverForwardWhenFacingGivenDirection(char startDirection, int[] startPosition, int[] endPosition)
        {
            var rover = new Rover(startDirection, positionX: startPosition[0], positionY: startPosition[1]);

            rover.Go(instructions: "f");

            Assert.That(rover.Direction, Is.EqualTo(startDirection));
            Assert.That(rover.PositionX, Is.EqualTo(endPosition[0]));
            Assert.That(rover.PositionY, Is.EqualTo(endPosition[1]));
        }

        [TestCase('N', new[] {5, 5}, new[] {5, 4})]
        [TestCase('S', new[] {5, 5}, new[] {5, 6})]
        [TestCase('E', new[] {5, 5}, new[] {4, 5})]
        [TestCase('W', new[] {5, 5}, new[] {6, 5})]
        public void MoveRoverBackwardWhenFacingGivenDirection(char startDirection, int[] startPosition, int[] endPosition)
        {
            var rover = new Rover(startDirection, positionX: startPosition[0], positionY: startPosition[1]);

            rover.Go(instructions: "b");
        }

        [TestCase('N', 'W')]
        [TestCase('W', 'S')]
        [TestCase('S', 'E')]
        [TestCase('E', 'N')]
        public void TurnRoverLeftWhenFacingGivenDirection(char startDirection, char endDirection)
        {
            var rover = new Rover(startDirection, positionX: 13, positionY: 37);

            rover.Go(instructions: "l");

            Assert.That(rover.Direction, Is.EqualTo(endDirection));
            Assert.That(rover.PositionX, Is.EqualTo(13));
            Assert.That(rover.PositionY, Is.EqualTo(37));
        }

        [TestCase('N', 'E')]
        [TestCase('E', 'S')]
        [TestCase('S', 'W')]
        [TestCase('W', 'N')]
        public void TurnRoverRightWhenFacingGivenDirection(char startDirection, char endDirection)
        {
            var rover = new Rover(startDirection, positionX: 6, positionY: 9);

            rover.Go(instructions: "r");

            Assert.That(rover.Direction, Is.EqualTo(endDirection));
            Assert.That(rover.PositionX, Is.EqualTo(6));
            Assert.That(rover.PositionY, Is.EqualTo(9));
        }

        [Test]
        public void MoveAndTurnRoverWithMultipleInstructions()
        {
            var rover = new Rover(direction: 'N', positionX: 5, positionY: 5);

            // N/5/5 -[f]-> N/5/6 -[r]-> E/5/6 -[b]-> E/4/6 -[b]-> E/3/6 -[l]-> N/3/6 -[f]-> N/3/7 -[l]-> W/3/7
            rover.Go(instructions: "frbblfl");

            Assert.That(rover.Direction, Is.EqualTo('W'));
            Assert.That(rover.PositionX, Is.EqualTo(3));
            Assert.That(rover.PositionY, Is.EqualTo(7));
        }
    }
}