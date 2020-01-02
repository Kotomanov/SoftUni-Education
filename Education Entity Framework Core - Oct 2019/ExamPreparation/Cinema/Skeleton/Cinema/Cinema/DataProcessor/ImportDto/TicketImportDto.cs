using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Cinema.DataProcessor.ImportDto
{
    [XmlType("Ticket")]
    public class TicketImportDto
    {
        [Required]
        [XmlElement("ProjectionId")]
        public int ProjectionId { get; set; }


        [Required]
        [Range(0.01, Double.MaxValue)]
        [XmlElement("Price")]
        public decimal Price { get; set; }

        [Required]
        //[XmlIgnore] // ??
        public int CustomerId { get; set; }
    }
}
