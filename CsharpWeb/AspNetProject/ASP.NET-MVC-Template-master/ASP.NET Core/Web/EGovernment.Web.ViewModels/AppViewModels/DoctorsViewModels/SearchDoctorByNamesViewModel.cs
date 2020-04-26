namespace EGovernment.Web.ViewModels.AppViewModels.DoctorsViewModels
{
    using EGovernment.Data.Models.Models.People;
    using EGovernment.Services.Mapping;

    public class SearchDoctorByNamesViewModel : IMapTo<Doctor>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
