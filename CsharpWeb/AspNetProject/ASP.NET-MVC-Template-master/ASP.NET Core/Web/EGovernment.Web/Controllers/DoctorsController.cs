namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;

    using EGovernment.Services.Data.DoctorsService;
    using EGovernment.Web.ViewModels.AppViewModels.DoctorsViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class DoctorsController : BaseController
    {
        private readonly IDoctorService doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            this.doctorService = doctorService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult ListAll()
        {
            var collection = this.doctorService.GetAllDoctors<SingleDoctorDisplayViewModel>();

            if (collection.Count == 0)
            {
                return this.NoContent();
            }

            AllDoctorsDisplayViewModel list = new AllDoctorsDisplayViewModel();
            list.DoctorsList = collection;

            return this.View(list);
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateAsync()
        {
            return this.View();
        }

        public IActionResult Search()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchAsync(SearchDoctorByNamesViewModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                this.TempData["Infomessage"] = "Please check the input details.";
                return this.View(inputModel);
            }

            if (!this.doctorService.DoctorExists(inputModel.FirstName, inputModel.LastName))
            {
                this.TempData["Infomessage"] = "No such doctor";
                return this.View(inputModel);
            }

            if (string.IsNullOrEmpty(inputModel.LastName) || string.IsNullOrEmpty(inputModel.FirstName))
            {
                this.TempData["Infomessage"] = "Please check the input details.";
                return this.View(inputModel);
            }

            var doctor = this.doctorService.GetDoctorByNames<SingleDoctorDisplayViewModel>(inputModel.FirstName, inputModel.LastName);
            return this.Redirect($"/Doctors/DisplayDoctor?id={doctor.Id}");
        }

        public IActionResult DisplayDoctor(int id)
        {
            if (!this.ModelState.IsValid)
            {
                this.TempData["Infomessage"] = "Nothing to show";
                return this.View();
            }

            if (id == 0)
            {
                this.TempData["Infomessage"] = "Nothing to show";
                return this.View();
            }

            SingleDoctorDisplayViewModel doctor = this.doctorService.GetDoctorById<SingleDoctorDisplayViewModel>(id);
            if (doctor == null)
            {
                this.TempData["Infomessage"] = "Nothing to show";
                return this.View();
            }

            return this.View(doctor);
        }
    }
}
