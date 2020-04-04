namespace EGovernment.Data.Models.Models.Health
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Models.People;

    public class MedicalRecord : BaseDeletableModel<int>
    {
        public MedicalRecord()
        {
            this.Visits = new HashSet<Visit>();
            this.Diagnoses = new HashSet<Diagnose>();
        }

        public virtual ICollection<Visit> Visits { get; set; }

        public virtual ICollection<Diagnose> Diagnoses { get; set; }
    }
}
