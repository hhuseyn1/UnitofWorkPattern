using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.Property(x => x.FirstName).IsRequired();

        builder.Property(x => x.LastName).IsRequired();

        builder.HasOne(x => x.Department)
            .WithMany(x => x.Teachers)
            .HasForeignKey(x => x.Id_Dep);
    }
}
