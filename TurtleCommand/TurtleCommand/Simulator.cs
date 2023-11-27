namespace TurtleCommand
{
    public class Simulator
    {
        public TurtleActions Turtle; 

        public void Place(int east, int north, string direction)
        {
            Process prc = new Process();
            if (prc.IsValidLocation(east, north))
            {
                Turtle = new TurtleActions
                {
                    direction = direction.ToLower(),
                    east = east,
                    north = north
                };
            }
        }

        public void TurtleMoves(string movement)
        {
            Process prc = new Process();
            switch (movement)
            {
                case "move":
                    if (prc.IsValidLocation(Turtle.east + 1, Turtle.north + 1)
                        && prc.IsValidLocation(Turtle.east - 1, Turtle.north - 1))
                    {
                        Turtle.Move();
                    }
                    break;
                case "right":
                    Turtle.TurnRight();
                    break;
                case "left":
                    Turtle.TurnLeft();
                    break;
            }
        }
        
        public string Report()
        {
            return Turtle.Report();
        }
    }
}
