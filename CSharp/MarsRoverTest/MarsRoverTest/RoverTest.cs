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

            rover.Move("f");
            
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

            rover.Move("b");
            
            Assert.That(rover.Direction, Is.EqualTo(startDirection));
            Assert.That(rover.PositionX, Is.EqualTo(endPosition[0]));
            Assert.That(rover.PositionY, Is.EqualTo(endPosition[1]));
        }
    }
}