namespace MarsRover
{
    public class Rover
    {
        public char Direction { get; }
        public int PositionX { get; }
        public int PositionY { get; private set; }

        public Rover(char direction, int positionX, int positionY)
        {
            Direction = direction;
            PositionX = positionX;
            PositionY = positionY;
        }

        public void Move(string instructions)
        {
            foreach (var instruction in instructions)
            {
                if (instructions == "f")
                {
                    if (Direction == 'N')
                    {
                        PositionY++;
                    }
                    if (Direction == 'S')
                    {
                        PositionY--;
                    }
                }
            }
        }
    }
}