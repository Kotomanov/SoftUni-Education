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
            this.DepartmentsEntities = new HashSet<DepartmentEntity>();
            this.DoctorsEntities = new HashSet<DoctorEntity>();
        }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public EntityType EntityType { get; set; }

        public string Url { get; set; }

        [Range(0, 1_000)]
        public int BedCount { get; set; }

        [Range(0, 1_000)]
        public int Availabebeds { get; set; }

        public virtual ICollection<DepartmentEntity> DepartmentsEntities { get; set; }

        public virtual ICollection<DoctorEntity> DoctorsEntities { get; set; }
    }
}
