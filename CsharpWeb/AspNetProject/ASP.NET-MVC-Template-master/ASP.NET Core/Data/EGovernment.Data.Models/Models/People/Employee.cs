                                                                                                                                                                                    namespace EGovernment.Data.Models.Models.People
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.Geographical;

    public class Employee : BaseDeletableModel<int>, IPerson
    {
        public Employee()
        {
            this.Positions = new HashSet<string>();
        }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string FirstName { get; set; }

        [StringLength(30, MinimumLength = 1)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        public string EGN { get; set; }

        [Required]
        [Range(1, 10_000)]
        public int AddressId { get; set; }

        [Required]
        public virtual Address Address { get; set; }

        [Required]
        [Range(1, 10_000)]
        public int ManagerId { get; set; } // EmployeeID - selfreferencing

        [Required]
        public bool IsManager { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public virtual ICollection<string> Positions { get; set; }
    }
}
