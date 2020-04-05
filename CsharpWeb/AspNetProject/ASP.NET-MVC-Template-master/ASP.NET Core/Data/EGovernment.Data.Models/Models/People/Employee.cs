namespace EGovernment.Data.Models.Models.People
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Data.Models.Models.Vehicles;

    public class Employee : BaseDeletableModel<int>, IPerson
    {
        public Employee()
        {
            this.Positions = new HashSet<ApplicationRole>();
            this.Team = new HashSet<Employee>();
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
        [StringLength(10)]
        [RegularExpression(@"[0-9]{10}")]
        public string EGN { get; set; }

        [Required]
        [Range(1, 10_000)]
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        [Range(1, 10_000)]
        public int ManagerId { get; set; } // EmployeeID - selfreferencing

        public virtual Employee Manager { get; set; }

        [Required]
        public bool IsManager { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public int? VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public virtual ICollection<ApplicationRole> Positions { get; set; }

        public virtual ICollection<Employee> Team { get; set; }
    }
}
