namespace EGovernment.Data.Models.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.Health;
    using EGovernment.Data.Models.Models.Health.Entities;

    public class EntityVisit
    {
        [Required]
        public int VisitId { get; set; }

        public virtual Visit Visit { get; set; }

        [Required]
        public int EntityId { get; set; }

        public virtual Entity Entity { get; set; }
    }
}
