﻿using MusicHub.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicHub.Data.Models
{
    public class Song
    {

        public Song()
        {
            this.SongPerformers = new HashSet<SongPerformer>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } // Date only ??

        [Required]
        public Genre Genre { get; set; }

        public int? AlbumId { get; set; } //nullable

        public Album Album { get; set; }

        [Required]
        public int WriterId { get; set; }

        public Writer Writer { get; set; }

        [Required]
        [Range(0,10_000_000_000_000)] // ??
        public decimal Price { get; set; }

        public ICollection<SongPerformer> SongPerformers { get; set; }
    }
}
