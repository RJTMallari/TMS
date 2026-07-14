namespace TMS.Server.Models;

public class RailLine
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string ShortName { get; set; } = string.Empty;

    public string PrimaryColor { get; set; } = string.Empty;

    public ICollection<Station> Stations { get; set; } = new List<Station>();
}