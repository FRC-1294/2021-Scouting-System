namespace _1294_Scouting
{
    //Autonomous
    public enum Auto
    {
        None,
        Moved,
        Scored
    }

    //Climbing
    public enum Climb
    {
        No,
        Yes
    }

   

    //Class for data per match per robot (Will be processed)
    public class RobotMatchData
    {
        public Auto auto;
        public bool wheelSpin;
        public bool wheelMatch;
        public bool climb;
        public RobotMatchData()
        {
            auto = Auto.None;
            wheelSpin = false;
            wheelMatch = false;
            climb = false;
        }
        public string toString()
        {
            return $"Autonomous: {auto}\n" +
                $"Color Wheel Spun: {wheelSpin}\n" +
                $"Color Wheel Match: {wheelMatch}\n" +
                $"Climb: {climb}\n";
        }
    }

    //Data to send to Mongo
    public class RobotCompleteData
    {

    }
}
