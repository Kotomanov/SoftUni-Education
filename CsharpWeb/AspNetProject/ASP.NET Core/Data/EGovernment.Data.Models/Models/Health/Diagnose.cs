namespace EGovernment.Data.Models.Models.Health
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.MappingTables;

    public class Diagnose : BaseDeletableModel<int>
    {
        public Diagnose()
        {
            this.DiagnosesRecords = new HashSet<RecordDiagnose>();
        }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string Description { get; set; }

        public virtual ICollection<RecordDiagnose> DiagnosesRecords { get; set; }
    }
}
