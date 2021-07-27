namespace MarsRover
{
    public class Rover
    {
        public char Direction { get; }
        public int PositionX { get; }
        public int PositionY { get; }

        public Rover(char direction, int positionX, int positionY)
        {
            Direction = direction;
            PositionX = positionX;
            PositionY = positionY;
        }

        public void Move(string instructions)
        {
            throw new System.NotImplementedException();
        }
    }
}