namespace EGovernment.Data.Models.Models.Health.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums.Entities.Health;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Data.Models.Models.MappingTables;

    public class Entity : BaseDeletableModel<int>
    {
        public Entity()
        {
            this.DepartmentsList = new HashSet<string>();
            this.DoctorsEntities = new HashSet<DoctorEntity>();
        }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public EntityType EntityType { get; set; }

        public string Url { get; set; }

        [Range(0, 1_000)]
        public int BedCount { get; set; }

        public virtual ICollection<string> DepartmentsList { get; set; } // enum in list? or string

        public virtual ICollection<DoctorEntity> DoctorsEntities { get; set; }
    }
}
