namespace EGovernment.Data.Models.Models.Health
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.Health.Entities;
    using EGovernment.Data.Models.Models.People;

    public class Visit : BaseDeletableModel<int>
    {
        public Visit()
        {
            this.PillsPerscribed = new HashSet<Medicine>();
            this.EntitiesVisited = new HashSet<Entity>();
        }

        [Required]
        [Range(1, 10_000_000)]
        public string PatientId { get; set; }

        public virtual Patient Patient { get; set; }

        [Required]
        [Range(1, 10_000)]
        public int DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual ICollection<Medicine> PillsPerscribed { get; set; }

        public virtual ICollection<Entity> EntitiesVisited { get; set; }
    }
}
