using NUnit.Framework;

namespace MarsRover
{
    public class RoverTest
    {
        [Test]
        public void MoveRoverForwardWhenFacingNorth()
        {
            var rover = new Rover(direction: 'N', positionX: 5, positionY: 5);

            rover.Move("f");
            
            Assert.That(rover.Direction, Is.EqualTo('N'));
            Assert.That(rover.PositionX, Is.EqualTo(5));
            Assert.That(rover.PositionY, Is.EqualTo(6));
        }
    }
}