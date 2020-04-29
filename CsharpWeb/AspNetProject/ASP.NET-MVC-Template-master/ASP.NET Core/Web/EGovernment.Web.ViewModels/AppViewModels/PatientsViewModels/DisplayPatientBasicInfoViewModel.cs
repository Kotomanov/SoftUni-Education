namespace EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels
{
    using EGovernment.Data.Models.Models.People;
    using EGovernment.Services.Mapping;

    public class DisplayPatientBasicInfoViewModel : IMapFrom<Patient>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EGN { get; set; }
    }
}
