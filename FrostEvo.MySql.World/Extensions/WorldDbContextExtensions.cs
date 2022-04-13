using Microsoft.Extensions.DependencyInjection;

namespace FrostEvo.MySql.World.Extensions;

public static class WorldDbContextExtensions
{
    public static Task AddWorldDbContext(this IServiceCollection services)
    {
        // var config = new Config();
        // var connString =
        //     $"Server={config.DatabaseConfig.Server};Database={config.DatabaseConfig.GameSchema};Uid={config.DatabaseConfig.Username};Pwd={config.DatabaseConfig.Password};{config.DatabaseConfig.Extra}";
        //
        // services.AddDbContextFactory<GameDbContext>(optionsBuilder =>
        // {
        //     optionsBuilder.UseMySql(connString, ServerVersion.AutoDetect(connString));
        //     optionsBuilder.EnableDetailedErrors();
        //     optionsBuilder.EnableSensitiveDataLogging();
        // });
        return Task.CompletedTask;
    }
}