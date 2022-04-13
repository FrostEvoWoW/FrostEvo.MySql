using FrostEvo.MySql.Domain.Models.User;
using FrostEvo.MySql.User.Mappings;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FrostEvo.MySql.User;

public class UserDbContext : IdentityDbContext<DbUser, DbRole, uint>
{
    public UserDbContext()
    {
    }

    public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        const string connString = "Server=localhost;Database=FrostEvoWoW.User;Uid=frostevo;Pwd=frostevo;Charset=utf8;Pooling=true;";

        optionsBuilder.UseMySql(connString, ServerVersion.AutoDetect(connString));
        optionsBuilder.EnableDetailedErrors();
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
    }
    
    public DbSet<DbCharacter> Characters { get; set; }
    public DbSet<DbIncident> Incidents { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<DbUser>().Map();
        builder.Entity<DbCharacter>().Map();
        builder.Entity<DbIncident>().Map();
    }
}