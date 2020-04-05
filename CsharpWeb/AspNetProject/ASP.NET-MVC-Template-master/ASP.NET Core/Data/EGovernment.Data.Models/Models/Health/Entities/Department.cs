namespace EGovernment.Data.Models.Models.Health.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums.Entities.Health;
    using EGovernment.Data.Models.Models.MappingTables;

    public class Department : BaseDeletableModel<int>
    {
        public Department()
        {
            this.DepartmentsEntities = new HashSet<DepartmentEntity>();
        }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        public DepartmentCode DepartmentCode { get; set; }

        public ICollection<DepartmentEntity> DepartmentsEntities { get; set; }
    }
}
