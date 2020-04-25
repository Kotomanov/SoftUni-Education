namespace EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels
{
    using EGovernment.Data.Models;
    using EGovernment.Services.Mapping;

    public class PatientPersonalInfoViewModel : IMapFrom<ApplicationUser>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EGN { get; set; }

        public int AddressId { get; set; } // ?? if there will be null ref exc?!!!

        public int DoctorId { get; set; } // ?? if there will be null ref exc?!!!

        public int MedicalRecordId { get; set; }
    }
}
