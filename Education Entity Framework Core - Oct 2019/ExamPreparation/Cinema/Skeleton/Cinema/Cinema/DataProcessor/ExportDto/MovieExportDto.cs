using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.DataProcessor.ExportDto
{
   public class MovieExportDto
    {
        public string MovieName { get; set; }

        public string Rating { get; set; } // formatted

        public string TotalIncomes { get; set; } // string formatted ? 

        public ICollection<CustomersExportDto> Customers { get; set; }
    }
}
