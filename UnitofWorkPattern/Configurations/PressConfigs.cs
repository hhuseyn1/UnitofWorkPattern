using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Configurations;

public class PressConfigs : IEntityTypeConfiguration<Press>
{
    public void Configure(EntityTypeBuilder<Press> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired();
    }
}
