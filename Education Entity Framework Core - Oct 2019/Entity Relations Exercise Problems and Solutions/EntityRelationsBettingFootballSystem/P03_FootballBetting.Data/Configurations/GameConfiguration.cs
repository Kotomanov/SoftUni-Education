using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(g => g.GameId);

            builder.Property(g => g.HomeTeamGoals)
                .IsRequired(true);

            builder.Property(g => g.AwayTeamGoals)
                .IsRequired(true);

            builder.Property(g => g.DateTime)
             .IsRequired(true);

            builder.Property(g => g.HomeTeamBetRate)
                .IsRequired(true);

            builder.Property(g => g.AwayTeamBetRate)
                .IsRequired(true);

            builder.Property(g => g.DrawBetRate)
                .IsRequired(true);

            builder.Property(g => g.Result)
                .IsRequired();

            builder.HasOne(g => g.HomeTeam)
                .WithMany(ht => ht.HomeGames)
                .HasForeignKey(g => g.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(g => g.AwayTeam)
                .WithMany(at => at.AwayGames)
                .HasForeignKey(g => g.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict); 
                
        }
    }
}
