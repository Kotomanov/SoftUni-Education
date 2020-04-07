namespace EGovernment.Data.Models.Models.MappingTables
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.Health;

    public class RecordDiagnose
    {
        [Required]
        public int MedicalRecordId { get; set; }

        public virtual MedicalRecord MedicalRecord { get; set; }

        [Required]
        public int DiagnoseId { get; set; }

        public virtual Diagnose Diagnose { get; set; }
    }
}
