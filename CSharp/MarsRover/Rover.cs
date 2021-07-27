namespace MarsRover
{
    public class Rover
    {
        public char Direction => direction[0];
        public int PositionX => position[0];
        public int PositionY => position[1];

        private string direction;
        private int[] position;

        public Rover(char direction, int positionX, int positionY)
        {
            this.direction = direction.ToString();
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
                    if (direction == "N")
                    {
                        direction = "W";
                    }
                    else if (direction == "S")
                    {
                        direction = "E";
                    }
                    else if (direction == "E")
                    {
                        direction = "N";
                    }
                    else if (direction == "W")
                    {
                        direction = "S";
                    }
                }
                else if (instruction == 'r')
                {
                    if (direction == "N")
                    {
                        direction = "E";
                    }
                    else if (direction == "S")
                    {
                        direction = "W";
                    }
                    else if (direction == "E")
                    {
                        direction = "S";
                    }
                    else if (direction == "W")
                    {
                        direction = "N";
                    }
                }
            }
        }
    }
}