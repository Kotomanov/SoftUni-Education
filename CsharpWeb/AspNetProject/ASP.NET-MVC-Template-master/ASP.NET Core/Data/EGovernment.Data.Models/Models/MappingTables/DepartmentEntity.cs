namespace EGovernment.Data.Models.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.Health.Entities;

    public class DepartmentEntity
    {
        [Required]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        [Required]
        public int EntityId { get; set; }

        public virtual Entity Entity { get; set; }
    }
}
