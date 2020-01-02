using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicHub.Data.Models
{
    public class Producer
    {
        public Producer()
        {
            this.Albums = new HashSet<Album>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(30)]
        public string Name { get; set; }

        [RegularExpression(@"\b[A-Z][a-z]+[\s{1}][A-Z][a-z]+\b")] 
        public string Pseudonym { get; set; }

        [RegularExpression(@"(?<!\d)[+]359 \d{3} \d{3} \d{3}\b")]  
        public string PhoneNumber { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
