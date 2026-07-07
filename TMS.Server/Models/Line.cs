namespace TMS.Server.Models
{
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;   // "MRT Line 3"
        public string ShortName { get; set; } = string.Empty;  // "MRT 3"
        public string PrimaryColor { get; set; } = string.Empty; // Hex code for React UI

    }

    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int RailLineId {  get; set; }
        public int SequenceNumber { get; set; }

        // Coordinates for mapping/distance checking

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
