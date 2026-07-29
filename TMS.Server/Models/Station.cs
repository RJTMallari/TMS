namespace TMS.Server.Models;

public class Station
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int RailLineId { get; set; }

    // Navigation property
    public RailLine? RailLine { get; set; } = null!;

    public int SequenceNumber { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public string? Transfer { get; set; }

    public string? FirstTrain { get; set; }

    public string? LastTrain { get; set; }
}