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
        public int powerCellsTop;
        public int powerCellsBottom;
        public RobotMatchData()
        {
            auto = Auto.None;
            wheelSpin = false;
            wheelMatch = false;
            climb = false;
            powerCellsBottom = 0;
            powerCellsTop = 0;
        }
        public string toString() => $"Autonomous: {auto}\n" +
            $"Power Cells Scored (Top): {powerCellsTop}\n" +
            $"Power Cells Scored (Bottom): {powerCellsBottom}\n" +
                $"Color Wheel Spun: {wheelSpin}\n" +
                $"Color Wheel Match: {wheelMatch}\n" +
                $"Climb: {climb}\n";
    }

    //Data to send to Mongo
    public class RobotCompleteData
    {

    }
}
