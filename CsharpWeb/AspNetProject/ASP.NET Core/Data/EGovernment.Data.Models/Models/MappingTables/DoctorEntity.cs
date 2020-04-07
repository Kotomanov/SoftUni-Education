namespace EGovernment.Data.Models.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.Health.Entities;
    using EGovernment.Data.Models.Models.People;

    public class DoctorEntity
    {
        [Required]
        public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

        [Required]
        public int EntityId { get; set; }

        public virtual Entity Entity { get; set; }
    }
}
