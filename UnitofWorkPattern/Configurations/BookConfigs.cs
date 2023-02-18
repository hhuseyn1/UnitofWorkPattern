﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UnitofWorkPattern.Models;

namespace UnitofWorkPattern.Configurations;
public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(x => x.Id_Press).IsRequired();
        builder.Property(x => x.Id_Category).IsRequired();
        builder.Property(x => x.Id_Theme).IsRequired();
        builder.Property(x => x.Id_Author).IsRequired();
        builder.Property(x => x.Quantity).HasDefaultValue(0);

        builder.Property(x => x.Name)
            .IsRequired();

        builder.Property(x => x.Comment)
            .IsRequired();

        builder.HasOne(x => x.Author)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.Id_Author);

        builder.HasOne(x => x.Theme)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.Id_Theme);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.Id_Category);

        builder.HasOne(x => x.Press)
            .WithMany(x => x.Books)
            .HasForeignKey(x => x.Id_Press);
    }
}