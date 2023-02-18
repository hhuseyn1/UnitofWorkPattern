using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Configurations;

public class T_CardsConfigs : IEntityTypeConfiguration<T_Card>
{
    public void Configure(EntityTypeBuilder<T_Card> builder)
    {
        builder.Property(x => x.DateOut)
            .IsRequired();

        builder.Property(x => x.DateIn)
            .IsRequired();

        builder.HasOne(x => x.Teacher)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Teacher);

        builder.HasOne(x => x.Lib)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Lib);

        builder.HasOne(x => x.Book)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Book);
    }
}
