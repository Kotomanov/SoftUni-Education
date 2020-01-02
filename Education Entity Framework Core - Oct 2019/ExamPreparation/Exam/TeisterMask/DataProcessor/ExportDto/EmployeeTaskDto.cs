using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeisterMask.DataProcessor.ExportDto
{
    public class EmployeeTaskDto
    {
        
        public string Username { get; set; }

        public ICollection<TaskEmployeeDto> Tasks { get; set; }
    }
}
