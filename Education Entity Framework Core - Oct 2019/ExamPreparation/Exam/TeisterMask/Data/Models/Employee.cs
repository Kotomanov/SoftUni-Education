using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Text;

namespace TeisterMask.Data.Models
{
    public class Employee
    {

        public Employee()
        {
            this.EmployeesTasks = new HashSet<EmployeeTask>();
        }


        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3), MaxLength(40)] // Todo regex
        [RegularExpression("[A-Za-z0-9]+")]
        public string Username { get; set; }

        [Required] // Todo mail validation
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                            + "@"
                            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$")]
        public string Email { get; set; }

        [Required] // Todo phone validation
        [RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}")] //??
        public string Phone { get; set; }

        public ICollection<EmployeeTask> EmployeesTasks { get; set; }
    }
}
