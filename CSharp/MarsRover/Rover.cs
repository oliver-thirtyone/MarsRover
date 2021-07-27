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
                    if (direction == "N")
                    {
                        position = new[] {position[0], position[1] + 1};
                    }

                    if (direction == "S")
                    {
                        position = new[] {position[0], position[1] - 1};
                    }

                    if (direction == "E")
                    {
                        position = new[] {position[0] + 1, position[1]};
                    }

                    if (direction == "W")
                    {
                        position = new[] {position[0] - 1, position[1]};
                    }
                }

                if (instruction == 'b')
                {
                    if (direction == "N")
                    {
                        position = new[] {position[0], position[1] - 1};
                    }

                    if (direction == "S")
                    {
                        position = new[] {position[0], position[1] + 1};
                    }

                    if (direction == "E")
                    {
                        position = new[] {position[0] - 1, position[1]};
                    }

                    if (direction == "W")
                    {
                        position = new[] {position[0] + 1, position[1]};
                    }
                }

                if (instruction == 'l')
                {
                    if (direction == "N")
                    {
                        direction = "W";
                        continue;
                    }

                    if (direction == "S")
                    {
                        direction = "E";
                        continue;
                    }

                    if (direction == "E")
                    {
                        direction = "N";
                        continue;
                    }

                    if (direction == "W")
                    {
                        direction = "S";
                    }
                }

                if (instruction == 'r')
                {
                    if (direction == "N")
                    {
                        direction = "E";
                        continue;
                    }

                    if (direction == "S")
                    {
                        direction = "W";
                        continue;
                    }

                    if (direction == "E")
                    {
                        direction = "S";
                        continue;
                    }

                    if (direction == "W")
                    {
                        direction = "N";
                    }
                }
            }
        }
    }
}