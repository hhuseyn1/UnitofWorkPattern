using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Configurations;


public class LibConfigs : IEntityTypeConfiguration<Lib>
{
    public void Configure(EntityTypeBuilder<Lib> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired();

        builder.Property(x => x.LastName)
            .IsRequired();
    }
}
