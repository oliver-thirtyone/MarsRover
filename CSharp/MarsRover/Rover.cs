namespace MarsRover
{
    public class Rover
    {
        public char Direction { get; private set; }
        public int PositionX => position[0];
        public int PositionY => position[1];

        private int[] position;

        public Rover(char direction, int positionX, int positionY)
        {
            Direction = direction;
            position = new[] {positionX, positionY};
        }

        public void Go(string instructions)
        {
            foreach (var instruction in instructions)
            {
                if (instruction == 'f')
                {
                    if (Direction == 'N')
                    {
                        position = new[] {position[0], position[1] + 1};
                    }
                    else if (Direction == 'S')
                    {
                        position = new[] {position[0], position[1] - 1};
                    }
                    else if (Direction == 'E')
                    {
                        position = new[] {position[0] + 1, position[1]};
                    }
                    else if (Direction == 'W')
                    {
                        position = new[] {position[0] - 1, position[1]};
                    }
                }
                else if (instruction == 'b')
                {
                    if (Direction == 'N')
                    {
                        position = new[] {position[0], position[1] - 1};
                    }
                    else if (Direction == 'S')
                    {
                        position = new[] {position[0], position[1] + 1};
                    }
                    else if (Direction == 'E')
                    {
                        position = new[] {position[0] - 1, position[1]};
                    }
                    else if (Direction == 'W')
                    {
                        position = new[] {position[0] + 1, position[1]};
                    }
                }
                else if (instruction == 'l')
                {
                    if (Direction == 'N')
                    {
                        Direction = 'W';
                    }
                    else if (Direction == 'S')
                    {
                        Direction = 'E';
                    }
                    else if (Direction == 'E')
                    {
                        Direction = 'N';
                    }
                    else if (Direction == 'W')
                    {
                        Direction = 'S';
                    }
                }
                else if (instruction == 'r')
                {
                    if (Direction == 'N')
                    {
                        Direction = 'E';
                    }
                    else if (Direction == 'S')
                    {
                        Direction = 'W';
                    }
                    else if (Direction == 'E')
                    {
                        Direction = 'S';
                    }
                    else if (Direction == 'W')
                    {
                        Direction = 'N';
                    }
                }
            }
        }
    }
}