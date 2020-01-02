using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace MusicHub.DataProcessor.ImportDtos
{
    [XmlType("Song")]
    public class SongImportDto
    {
        //which after which??
        [Required]
        [MinLength(3), MaxLength(20)]
        [XmlElement("Name")]
        public string Name { get; set; }


        [Required]
        [XmlElement("Duration")]
        public string Duration { get; set; }

        [Required]
        [XmlElement("CreatedOn")]
        public string CreatedOn { get; set; }

        [Required]
        [XmlElement("Genre")]
        public string Genre { get; set; }

        [XmlElement("AlbumId")]
        public int? AlbumId { get; set; }

        [Required]
        [XmlElement("WriterId")]
        public int WriterId { get; set; }

        [Required]
        [Range(0, 10_000_000_000_000)] // ??
        [XmlElement("Price")]
        public decimal Price { get; set; }
    }
}
