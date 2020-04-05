﻿namespace EGovernment.Data.Models.Models.People
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.Health.Entities;
    using EGovernment.Data.Models.Models.MappingTables;

    public class Doctor : BaseDeletableModel<int>, IPerson
    {
        public Doctor()
        {
            this.DoctorsEntities = new HashSet<DoctorEntity>();
            this.SpecialtiesDoctors = new HashSet<SpecialtyDoctor>();
            this.PatientsList = new HashSet<Patient>();
        }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string FirstName { get; set; }

        [StringLength(30, MinimumLength = 1)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string LastName { get; set; }

        public string EGN { get; set; }

        public int AddressId { get; set; }

        public virtual ICollection<SpecialtyDoctor> SpecialtiesDoctors { get; set; }

        public virtual ICollection<DoctorEntity> DoctorsEntities { get; set; }

        public virtual ICollection<Patient> PatientsList { get; set; }

        [Range(0, int.MaxValue)]
        public int VisitsCount { get; set; }
    }
}
