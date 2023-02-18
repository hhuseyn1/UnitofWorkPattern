using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Configurations;


public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(x => x.FirstName).IsRequired();

        builder.Property(x => x.LastName).IsRequired();

        builder.HasOne(x => x.Group)
            .WithMany(x => x.Students)
            .HasForeignKey(x => x.Id_Group);
    }
}
