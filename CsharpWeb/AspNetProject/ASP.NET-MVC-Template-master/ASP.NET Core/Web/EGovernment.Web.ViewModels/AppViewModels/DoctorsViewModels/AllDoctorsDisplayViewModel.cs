namespace EGovernment.Web.ViewModels.AppViewModels.DoctorsViewModels
{
    using System.Collections.Generic;

    public class AllDoctorsDisplayViewModel
    {
        public ICollection<SingleDoctorDisplayViewModel> DoctorsList { get; set; }
    }
}
