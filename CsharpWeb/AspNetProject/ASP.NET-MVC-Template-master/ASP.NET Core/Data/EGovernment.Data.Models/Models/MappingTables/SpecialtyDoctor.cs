namespace EGovernment.Data.Models.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.People;

    public class SpecialtyDoctor
    {
        [Required]
        public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

        [Required]
        public int SpecialtyId { get; set; }

        public virtual Specialty Specialty { get; set; }
    }
}
