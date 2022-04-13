using Microsoft.EntityFrameworkCore;

namespace FrostEvo.MySql.World;

public class WorldDbContext : DbContext
{
    public WorldDbContext()
    {
    }

    public WorldDbContext(DbContextOptions<WorldDbContext> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        const string connString = "Server=localhost;Database=FrostEvoWoW.World;Uid=frostevo;Pwd=frostevo;Charset=utf8;Pooling=true;";

        optionsBuilder.UseMySql(connString, ServerVersion.AutoDetect(connString));
        optionsBuilder.EnableDetailedErrors();
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}