using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Configurations;


public class S_CardConfigs : IEntityTypeConfiguration<S_Card>
{
    public void Configure(EntityTypeBuilder<S_Card> builder)
    {
        builder.Property(x => x.DateOut)
                .IsRequired();

        builder.Property(x => x.DateIn)
            .IsRequired();

        builder.HasOne(x => x.Student)
            .WithMany(x => x.S_Cards)
            .HasForeignKey(x => x.Id_Student);

        builder.HasOne(x => x.Lib)
            .WithMany(x => x.S_Cards)
            .HasForeignKey(x => x.Id_Lib);

        builder.HasOne(x => x.Book)
            .WithMany(x => x.S_Cards)
            .HasForeignKey(x => x.Id_Book);
    }
}
