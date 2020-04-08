namespace EGovernment.Data.Models.Models.Health
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.MappingTables;
    using EGovernment.Data.Models.Models.People;

    public class Visit : BaseDeletableModel<int>
    {
        public Visit()
        {
            this.MedicinesPerscribed = new HashSet<MedicineVisit>();
            this.EntitiesVisited = new HashSet<EntityVisit>();
        }

        [Required]
        [Range(1, 10_000)]
        public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

        public int MedicalRecordId { get; set; }

        public virtual MedicalRecord MedicalRecord { get; set; }

        public virtual ICollection<MedicineVisit> MedicinesPerscribed { get; set; }

        public virtual ICollection<EntityVisit> EntitiesVisited { get; set; }
    }
}
