using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(p=>p.PlayerId);

            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired(true)
                .IsUnicode(true);

            builder.Property(p => p.SquadNumber)
                .IsRequired(true);

            builder.Property(p => p.IsInjured)
                .IsRequired(true);

            builder.HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Position)
                .WithMany(p => p.Players)
                .HasForeignKey(p=>p.PositionId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
