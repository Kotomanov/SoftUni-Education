using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.DataProcessor.ExportDto
{
    public class ExportAuthorsDto
    {
        public string AuthorName { get; set; }

        public List<BooksExportDto> Books { get; set; } // or Icollection!!!! 
    }
}
