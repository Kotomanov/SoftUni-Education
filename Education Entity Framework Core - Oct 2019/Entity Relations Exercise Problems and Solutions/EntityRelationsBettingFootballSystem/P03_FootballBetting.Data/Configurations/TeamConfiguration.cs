using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.TeamId);

            builder.Property(t => t.Name)
                .HasMaxLength(100)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(t => t.LogoUrl)
                .HasMaxLength(100)
                .IsRequired(true)
                .IsUnicode(false);

            builder.Property(t => t.Initials)
                .HasMaxLength(5)
                .IsRequired(true)
                .IsUnicode(true);

            builder.Property(t => t.Budget)
                .IsRequired(true);

            builder.HasOne(t => t.PrimaryKitColor)
                .WithMany(c => c.PrimaryKitTeams)
                .HasForeignKey(t => t.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.SecondaryKitColor)
                .WithMany(c => c.SecondaryKitTeams)
                .HasForeignKey(t => t.SecondaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.Town)
                .WithMany(to => to.Teams)
                .HasForeignKey(t => t.TownId)
                .OnDelete(DeleteBehavior.Restrict); 

        }
    }
}
