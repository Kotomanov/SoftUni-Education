namespace EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.People;
    using EGovernment.Services.Mapping;

    public class PatientUpdateInfoViewModel : IMapTo<Patient>
    {
        [Required]
        [StringLength(30, MinimumLength = 1)]
        [Display(Name = "First Name*")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        [Display(Name = "Last Name*")]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression(@"[0-9]{10}")]
        [Display(Name = "ЕГеНе*")]
        public string EGN { get; set; }

        [Required]
        [Range(1, 10_000_000)]
        [Display(Name = "Address code")]
        public int AddressId { get; set; }

        [Required]
        [Range(1, 10_000)]
        [Display(Name = "GP")]
        public int DoctorId { get; set; } // GP

        [Required]
        [Range(1, 10_000_000)]
        [Display(Name = "Patient's record id")]
        public int MedicalRecordId { get; set; }
    }
}
