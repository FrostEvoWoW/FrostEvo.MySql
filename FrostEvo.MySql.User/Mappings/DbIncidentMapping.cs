using FrostEvo.MySql.Domain.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrostEvo.MySql.User.Mappings;

public static class DbIncidentMapping
{
    public static void Map(this EntityTypeBuilder<DbIncident> builder)
    {
        builder.ToTable("Incidents");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseMySqlIdentityColumn();
    }
}