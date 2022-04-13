using FrostEvo.MySql.Domain.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrostEvo.MySql.User.Mappings;

public static class DbUserMapping
{
    public static void Map(this EntityTypeBuilder<DbUser> builder)
    {
        builder.ToTable("Users");
        builder.HasMany<DbCharacter>(x => x.Clients)
            .WithOne(x => x.User).HasForeignKey(x => x.UserId);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseMySqlIdentityColumn().HasColumnOrder(1);
        builder.Property(x => x.UserName).HasColumnName("Username").HasColumnOrder(2);
        builder.Property(x => x.PasswordHash).HasColumnName("Password").HasColumnOrder(3);
        builder.Property(x => x.RoleType).HasColumnOrder(4);
    }
}