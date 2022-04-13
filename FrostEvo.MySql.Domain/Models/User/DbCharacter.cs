namespace FrostEvo.MySql.Domain.Models.User;

public class DbCharacter
{
    public uint Id { get; set; }
    public string Name { get; set; }
    public ulong Experience { get; set; }
    public byte Level { get; set; }
    public byte Race { get; set; }
    public byte Class { get; set; }
    public uint UserId { get; set; }
    public DbUser User { get; set; }
}