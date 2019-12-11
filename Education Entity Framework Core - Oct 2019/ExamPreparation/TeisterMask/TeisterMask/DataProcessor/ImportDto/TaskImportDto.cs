using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using TeisterMask.Data.Models.Enums;

namespace TeisterMask.DataProcessor.ImportDto
{

    [XmlType("Task")]
    public class TaskImportDto
    {
        [XmlIgnore]
        public int Id { get; set; } //????

        [Required]
        [MinLength(2), MaxLength(40)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Required]
        [XmlElement("OpenDate")]
        public string OpenDate { get; set; } // string and convert ? 

        [Required]
        [XmlElement("DueDate")]
        public string DueDate { get; set; } // convert ?

        [Required]
        [XmlElement("ExecutionType")]
        public string ExecutionType { get; set; } //  ExecutionType

        [Required]
        [XmlElement("LabelType")]
        public string  LabelType { get; set; } // LabelType
    }
}
