namespace EGovernment.Web.ViewModels.AppViewModels.DoctorsViewModels
{
    using EGovernment.Data.Models.Models.People;
    using EGovernment.Services.Mapping;

    public class SingleDoctorDisplayViewModel : IMapFrom<Doctor>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
