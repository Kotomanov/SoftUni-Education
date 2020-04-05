namespace EGovernment.Data.Models.Models.People
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Data.Models.Models.Health;
    using EGovernment.Data.Models.Models.MappingTables;

    public class Doctor : BaseDeletableModel<int>, IPerson
    {
        public Doctor()
        {
            this.DoctorsEntities = new HashSet<DoctorEntity>();
            this.SpecialtiesDoctors = new HashSet<SpecialtyDoctor>();
            this.PatientsList = new HashSet<Patient>();
            this.Visits = new HashSet<Visit>();
        }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string FirstName { get; set; }

        [StringLength(30, MinimumLength = 1)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string LastName { get; set; }

        [StringLength(10)]
        [RegularExpression(@"[0-9]{10}")]
        public string EGN { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<SpecialtyDoctor> SpecialtiesDoctors { get; set; }

        public virtual ICollection<DoctorEntity> DoctorsEntities { get; set; }

        public virtual ICollection<Patient> PatientsList { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
