namespace _1294_Scouting
{
    //Autonomous
    public enum Auto
    {
        None,
        Moved,
        Scored
    }

    //Color Wheel
    public enum ColorWheel
    {
        No,
        Spin,
        Match
    }

    //Climbing
    public enum Climb
    {
        No,
        Yes,
        Balance
    }

   

    //Class for data per match per robot (Will be processed)
    public class RobotMatchData
    {
        public Auto auto;
        public ColorWheel wheel;
        public Climb climb;
        public RobotMatchData()
        {
            auto = Auto.None;
            wheel = ColorWheel.No;
            climb = Climb.No;
        }
        public string toString()
        {
            return $"Autonomous: {auto}\n" +
                $"Color Wheel: {wheel}\n" +
                $"Climb: {climb}\n";
        }
    }

    //Data to send to Mongo
    public class RobotCompleteData
    {

    }
}
