using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired();

        builder.HasOne(x => x.Faculty)
            .WithMany(x => x.Groups)
            .HasForeignKey(x => x.Id_Faculty);
    }
}
