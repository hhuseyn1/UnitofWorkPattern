using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Configurations;

public class DepartmentConfigs : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired();
    }
}
