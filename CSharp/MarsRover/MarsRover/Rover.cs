namespace MarsRover
{
    public class Rover
    {
        public char Direction { get; private set; }
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Rover(char direction, int positionX, int positionY)
        {
            Direction = direction;
            PositionX = positionX;
            PositionY = positionY;
        }

        public void Go(string instructions)
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
                else if (instruction == 'b')
                {
                    if (Direction == 'N')
                    {
                        PositionY--;
                    }
                    else if (Direction == 'S')
                    {
                        PositionY++;
                    }
                    else if (Direction == 'E')
                    {
                        PositionX--;
                    }
                    else if (Direction == 'W')
                    {
                        PositionX++;
                    }
                }
                else if (instruction == 'l')
                {
                    Direction = Direction switch
                    {
                        'N' => 'W',
                        'S' => 'E',
                        'E' => 'N',
                        'W' => 'S',
                        _ => Direction
                    };
                }
                else if (instruction == 'r')
                {
                    Direction = Direction switch
                    {
                        'N' => 'E',
                        'S' => 'W',
                        'E' => 'S',
                        'W' => 'N',
                        _ => Direction
                    };
                }
            }
        }
    }
}