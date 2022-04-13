using FrostEvo.MySql.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace FrostEvo.MySql.Domain.Models.User;

public class DbUser : IdentityUser<uint>
{
    public RoleType RoleType { get; set; }
    public string SecurityQuestion { get; set; }
    public string SecurityAnswer { get; set; }
    public string SecurityCode { get; set; }
    public uint ConquerPoints { get; set; }
    public uint BoundConquerPoints { get; set; }
    public uint VotePoints { get; set; }
    public long LoginToken { get; set; }
    public IList<DbCharacter> Clients { get; set; }
}