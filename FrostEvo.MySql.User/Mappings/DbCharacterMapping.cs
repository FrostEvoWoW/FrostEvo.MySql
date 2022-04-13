using FrostEvo.MySql.Domain.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrostEvo.MySql.User.Mappings;

public static class DbCharacterMapping
{
    public static void Map(this EntityTypeBuilder<DbCharacter> builder)
    {
        builder.ToTable("Characters");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseMySqlIdentityColumn();
        builder.Property(x => x.Name).HasMaxLength(16);
    }
}