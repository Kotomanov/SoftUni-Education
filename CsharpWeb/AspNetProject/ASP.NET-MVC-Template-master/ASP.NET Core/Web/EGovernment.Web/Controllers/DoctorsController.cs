namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;

    using EGovernment.Services.Data.DoctorsService;
    using EGovernment.Web.ViewModels.AppViewModels.DoctorsViewModels;
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

        // [Authorize(Roles = "Administrator")] or move to admin part?
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

        // [Authorize(Roles = "Administrator")] or move to admin part?
        // Task httppost
        public IActionResult Search() // find by id? and display
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

            return this.RedirectToAction("DisplayDoctor", doctor);
        }

        public IActionResult DisplayDoctor(SingleDoctorDisplayViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                this.TempData["Infomessage"] = "Nothing to show";
                return this.View(input);
            }

            if (input.Id == 0 || input.FirstName == null || input.LastName == null )
            {
                this.TempData["Infomessage"] = "Nothing to show";
                return this.View(input);
            }

            // service?

            var doctor = this.doctorService.GetDoctorByNames<SingleDoctorDisplayViewModel>(input.FirstName, input.LastName);

            return this.View(doctor);
        }
    }
}
