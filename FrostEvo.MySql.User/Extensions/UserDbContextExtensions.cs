using FrostEvo.MySql.Domain.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace FrostEvo.MySql.User.Extensions;

public static class UserDbContextExtensions
{
    public static Task AddUserDbContext(this IServiceCollection services)
    {
        // if (!Directory.Exists(Config.DbPath))
        //     Directory.CreateDirectory(Config.DbPath);
        //
        // var cfg = new Config();
        // services.AddDbContextFactory<UserDbContext>(optionsBuilder =>
        //     {
        //         optionsBuilder.UseSqlServer(
        //             $"Server={cfg.DatabaseConfig.Server};Database={cfg.DatabaseConfig.UserSchema};{cfg.DatabaseConfig.Extra}");
        //         optionsBuilder.EnableDetailedErrors();
        //         optionsBuilder.EnableSensitiveDataLogging();
        //     }).AddIdentityCore<DbUser>(options =>
        //     {
        //         options.Password.RequiredLength = 3;
        //         options.Password.RequireNonAlphanumeric = options.Password.RequireLowercase =
        //             options.Password.RequireUppercase = options.Password.RequireDigit = false;
        //     })
        //     .AddEntityFrameworkStores<UserDbContext>()
        //     .AddUserManager<UserManager<DbUser>>().Services
        //     .AddTransient<IPasswordHasher<DbUser>, CustomPasswordEncryption>();
        
        return Task.CompletedTask;
    }
}