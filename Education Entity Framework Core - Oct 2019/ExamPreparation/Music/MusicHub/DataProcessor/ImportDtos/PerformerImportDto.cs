using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace MusicHub.DataProcessor.ImportDtos
{
    [XmlType("Performer")] // problem "Import Song Performers"
    public class PerformerImportDto
    {
        [Required]
        [MinLength(3), MaxLength(20)]
        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        [XmlElement("LastName")]
        public string LastName { get; set; }

        [Required]
        [Range(18, 70)]
        [XmlElement("Age")]
        public int Age { get; set; }


        [Required]
        [Range(0, 10_000_000_000)] 
        [XmlElement("NetWorth")]
        public decimal NetWorth { get; set; }

        [XmlArray("PerformersSongs")]
        public SongIdImportDto[] SongsList { get; set; }
    }
}
