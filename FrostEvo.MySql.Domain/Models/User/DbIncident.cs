using FrostEvo.MySql.Domain.Enums;

namespace FrostEvo.MySql.Domain.Models.User;

public class DbIncident
{
    public uint Id { get; set; }
    public uint OwnerId { get; set; }
    public IncidentType Type { get; set; }
    public string Reason { get; set; }
    public DateTime Time { get; set; }
    public DateTime Expires { get; set; }
    public string IpAddress { get; set; }
    public string MacAddress { get; set; }
    public string HardwareId { get; set; }
}