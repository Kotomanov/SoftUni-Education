namespace EGovernment.Data.Models.Models.Health
{
    using System.Collections.Generic;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.MappingTables;
    using EGovernment.Data.Models.Models.People;

    public class MedicalRecord : BaseDeletableModel<int>
    {
        public MedicalRecord()
        {
            this.Visits = new HashSet<Visit>();
            this.DiagnosesRecords = new HashSet<RecordDiagnose>();
        }

        public int PatientId { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }

        public virtual ICollection<RecordDiagnose> DiagnosesRecords { get; set; }
    }
}
