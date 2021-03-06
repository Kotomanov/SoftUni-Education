﻿namespace EGovernment.Data.Models.Models.People
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Data.Models.Models.Health;

    public class Patient : BaseDeletableModel<string>, IPerson
    {
        public Patient()
        {
            this.Id = Guid.NewGuid().ToString();
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
        [Range(1, 10_000_000)]
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        [Required]
        [Range(1, 10_000)]
        public int DoctorId { get; set; } // GP

        public virtual Doctor Doctor { get; set; }

        [Required]
        [Range(1, 10_000_000)]
        public int MedicalRecordId { get; set; }

        public virtual MedicalRecord MedicalRecord { get; set; }
    }
}
