using Microsoft.EntityFrameworkCore;

namespace FrostEvo.MySql.Web;

public class WebDbContext : DbContext
{
    public WebDbContext()
    {
    }

    public WebDbContext(DbContextOptions<WebDbContext> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
            return;

        const string connString = "Server=localhost;Database=FrostEvoWoW.Web;Uid=frostevo;Pwd=frostevo;Charset=utf8;Pooling=true;";

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