using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace TeisterMask.DataProcessor.ImportDto
{
    [XmlType("Project")]
    public class ProjectImportDto
    {
        [Required]
        [MinLength(2), MaxLength(40)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Required]
        [XmlElement("OpenDate")]
        public string OpenDate { get; set; } // string

        [XmlElement("DueDate")]
        public string DueDate { get; set; } // string ? //DateTime?

        // collection of tasks 

        [XmlArray("Tasks")]
        public TaskImportDto[] Tasks { get; set; }
    }
}
