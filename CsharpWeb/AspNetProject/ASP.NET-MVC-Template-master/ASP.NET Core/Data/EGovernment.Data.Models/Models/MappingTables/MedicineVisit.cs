namespace EGovernment.Data.Models.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.Health;

    public class MedicineVisit
    {
        [Required]
        public int MedicineId { get; set; }

        public virtual Medicine Medicine { get; set; }

        [Required]
        public int VisitId { get; set; }

        public virtual Visit Visit { get; set; }
    }
}
