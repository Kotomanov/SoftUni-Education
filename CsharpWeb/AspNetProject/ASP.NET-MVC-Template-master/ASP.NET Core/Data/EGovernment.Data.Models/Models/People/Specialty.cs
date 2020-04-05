namespace EGovernment.Data.Models.Models.People
{
    using System.Collections.Generic;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums.Roles;
    using EGovernment.Data.Models.Models.MappingTables;

    public class Specialty : BaseDeletableModel<int>
    {
        public Specialty()
        {
            this.SpecialtiesDoctors = new HashSet<SpecialtyDoctor>();
        }

        public string Name { get; set; }

        public DoctorSpecialty DoctorSpecialty { get; set; }

        public virtual ICollection<SpecialtyDoctor> SpecialtiesDoctors { get; set; }
    }
}
