using BookShop.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace BookShop.DataProcessor.ImportDto
{
    [XmlType("Book")]
    public class BookImportDto
    {

        [Required]
        [MinLength(3), MaxLength(30)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Required]
        [XmlElement("Genre")]
        public int Genre { get; set; } // or int???????Genre

        [Range(0.01, Double.MaxValue)]
        [XmlElement("Price")]
        public decimal Price { get; set; } // max decimal

        [Range(50, 5000)]
        [XmlElement("Pages")]
        public int Pages { get; set; }

        [Required]
        [XmlElement("PublishedOn")]
        public string PublishedOn { get; set; } // or datetime???

    }
}
