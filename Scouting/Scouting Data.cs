using MongoDB.Bson;

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
        Park,
        Yes,
        Balance
    }



    //Class for data per match per robot (Will be processed)
    public class RobotMatchData
    {
        public int number;
        public int match;
        public Auto auto;
        public bool wheelSpin;
        public bool wheelMatch;
        public Climb climb;
        public int powerCellsTop;
        public int powerCellsBottom;
        public RobotMatchData(int teamNumber, int thisMatch)
        {
            auto = Auto.None;
            wheelSpin = false;
            wheelMatch = false;
            climb = Climb.No;
            powerCellsBottom = 0;
            powerCellsTop = 0;
            number = teamNumber;
            match = thisMatch;
        }
        public override string ToString() => $"Team: {number}" +
            $"Match: {match}" +
            $"Autonomous: {auto}\n" +
            $"Power Cells Scored (Top): {powerCellsTop}\n" +
            $"Power Cells Scored (Bottom): {powerCellsBottom}\n" +
                $"Color Wheel Spun: {wheelSpin}\n" +
                $"Color Wheel Match: {wheelMatch}\n" +
                $"Climb: {climb}\n";

        public BsonDocument GetMongoDocument() => new BsonDocument {
                {"Team Number",  number},
                {"Match", match },
                {"PowerCells Top", powerCellsTop},
                {"PowerCells Bottom", powerCellsBottom },
                {"Color Wheel", new BsonDocument{{"Spin", wheelSpin}, {"Match", wheelMatch } } },
                {"Climb", climb }
            };
    }
}
