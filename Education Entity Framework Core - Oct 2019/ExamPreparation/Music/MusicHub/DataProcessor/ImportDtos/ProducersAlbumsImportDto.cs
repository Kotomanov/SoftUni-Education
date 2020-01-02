using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicHub.DataProcessor.ImportDtos
{
    public class ProducersAlbumsImportDto
    {

        [Required]
        [MinLength(3), MaxLength(30)]
        public string Name { get; set; }


        [RegularExpression(@"\b[A-Z][a-z]+[\s{1}][A-Z][a-z]+\b")] 
        public string Pseudonym { get; set; }

        [RegularExpression(@"\+359 [0-9]{3} [0-9]{3} [0-9]{3}")]  
        public string PhoneNumber { get; set; }

        public AlbumImportDto[] Albums { get; set; }
    }
}
