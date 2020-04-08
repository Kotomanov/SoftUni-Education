namespace EGovernment.Data.Models.Models.Health
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.MappingTables;

    public class Medicine : BaseDeletableModel<int>
    {
        public Medicine()
        {
            this.MedicinesPerscribed = new HashSet<MedicineVisit>();
        }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        [Range(1, 1000_000)]
        public int AvailableQuantity { get; set; }

        [Range(1, int.MaxValue)]
        public int TotalQuantity { get; set; }

        public virtual ICollection<MedicineVisit> MedicinesPerscribed { get; set; }
    }
}
