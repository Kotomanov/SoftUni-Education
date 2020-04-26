namespace EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models;
    using EGovernment.Services.Mapping;

    public class CheckPatientStatusViewModel : IMapFrom<ApplicationUser>
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
        [RegularExpression(@"[0-9]{10}")]
        [Display(Name = "ЕГеНе*")]
        public string EGN { get; set; }
    }
}
