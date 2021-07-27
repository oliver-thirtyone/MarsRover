namespace MarsRover
{
    public class Rover
    {
        public char Direction { get; }
        public int PositionX { get; private set; }
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
                if (instruction == 'f')
                {
                    if (Direction == 'N')
                    {
                        PositionY++;
                    }
                    else if (Direction == 'S')
                    {
                        PositionY--;
                    }
                    else if (Direction == 'E')
                    {
                        PositionX++;
                    }
                    else if (Direction == 'W')
                    {
                        PositionX--;
                    }
                }
            }
        }
    }
}