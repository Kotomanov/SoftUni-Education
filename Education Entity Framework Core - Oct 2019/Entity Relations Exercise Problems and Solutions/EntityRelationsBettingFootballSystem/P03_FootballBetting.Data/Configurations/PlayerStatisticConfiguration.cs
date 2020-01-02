﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.Configurations
{
    public class PlayerStatisticConfiguration : IEntityTypeConfiguration<PlayerStatistic>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistic> builder)
        {
            builder.HasKey(ps=> new
            {
            ps.GameId,
            ps.PlayerId
            });

            builder.HasOne(ps => ps.Player)
                .WithMany(s => s.PlayerStatistics)
                .HasForeignKey(ps => ps.PlayerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ps => ps.Game)
                .WithMany(ps => ps.PlayerStatistics)
                .HasForeignKey(ps => ps.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(ps => ps.ScoredGoals)
                .IsRequired(true);

            builder.Property(ps => ps.Assists)
                .IsRequired(true);

            builder.Property(ps => ps.MinutesPlayed)
                .IsRequired(true);



        }
    }
}
