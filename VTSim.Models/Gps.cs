namespace VTSim.Models
{
    public abstract class Gps
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public class StationaryGps : Gps
    {}

    public class MovingGps : Gps
    {
        public decimal Velocity { get; set; }
        public decimal Direction { get; set; }
    }

}
