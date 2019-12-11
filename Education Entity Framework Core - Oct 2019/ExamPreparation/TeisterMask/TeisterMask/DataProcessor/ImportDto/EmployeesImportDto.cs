using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeisterMask.DataProcessor.ImportDto
{
    public class EmployeesImportDto
    {

       
        [JsonProperty("Username")]
        [Required]
        [MinLength(3), MaxLength(40)] // Todo regex
        [RegularExpression("[A-Za-z0-9]+")]
        public string Username { get; set; }

        
        [JsonProperty("Email")]
        [EmailAddress]
        [Required] // Todo mail validation
        public string Email { get; set; }

        [JsonProperty("Phone")]
        [Required] // Todo phone validation
        [RegularExpression("^[0-9]{3}-[0-9]{3}-[0-9]{4}$")] //??
        public string Phone { get; set; }

        [JsonProperty("Tasks")]
        public int[] Tasks { get; set; }
    }
}
