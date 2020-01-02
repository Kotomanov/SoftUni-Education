using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicHub.DataProcessor.ImportDtos
{
    public class WritersImportDto
    {
        [Required]
        [MinLength(3), MaxLength(20)]
        public string Name { get; set; }

        [RegularExpression(@"\b[A-Z][a-z]+[\s{1}][A-Z][a-z]+\b")]
        public string Pseudonym { get; set; }
    }
}
