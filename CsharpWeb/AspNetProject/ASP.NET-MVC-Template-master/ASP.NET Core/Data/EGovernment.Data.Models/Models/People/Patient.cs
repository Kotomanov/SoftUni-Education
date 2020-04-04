namespace EGovernment.Data.Models.Models.People
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Data.Models.Models.Health;

    public class Patient : BaseDeletableModel<string>, IPerson
    {
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
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        [Required]
        public int DoctorId { get; set; } // GP

        public virtual Doctor Doctor { get; set; }

        [Required]
        public int MedicalRecordId { get; set; }

        public virtual MedicalRecord MedicalRecord { get; set; }
    }
}
