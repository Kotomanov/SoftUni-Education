using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Cinema.DataProcessor.ExportDto
{

    [XmlType("Customer")]
    public class CustomerTicketsExport
    {
        [XmlAttribute("FirstName")]
        public string FirstName { get; set; }

        [XmlAttribute("LastName")]
        public string LastName { get; set; }

        public string SpentMoney { get; set; } // string or decimal 

        public string SpentTime { get; set; } // string or time ?
    }
}
