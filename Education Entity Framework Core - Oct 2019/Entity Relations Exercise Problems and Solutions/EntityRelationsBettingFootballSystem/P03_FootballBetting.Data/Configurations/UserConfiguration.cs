using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u=>u.UserId);

            builder.Property(u => u.Username)
                .HasMaxLength(30)
                .IsRequired(true)
                .IsUnicode(false);

            builder.Property(u => u.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsRequired(true); 

            builder.Property(u=>u.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired(true);

           builder.Property(u=>u.Name)
                .HasMaxLength(100)
                .IsUnicode(true)
                .IsRequired(false);

            builder.Property(u => u.Balance)
                .IsRequired(true); 
        }
    }
}
