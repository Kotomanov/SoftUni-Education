namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;

    using EGovernment.Services.Data.PatientsServices;
    using EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class PatientsController : BaseController
    {
        private readonly IPatientService patientService;

        public PatientsController(IPatientService patientService)
        {
            this.patientService = patientService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(PatientUpdateInfoViewModel patientInput)
        {
            if (!this.ModelState.IsValid)
            {
                this.TempData["Infomessage"] = "Invalid input";
                return this.View(patientInput);
            }

            if (this.patientService.PatientExists(patientInput.FirstName, patientInput.LastName, patientInput.EGN))
            {
                this.TempData["Infomessage"] = "Such patient exists";
                return this.View(patientInput);
            }

            await this.patientService.CreatePatientAsync(patientInput);

            return this.Redirect("/EGovServices/SelectProfileSetOptions");
        }

        public IActionResult PatientRecord()
        {
            return this.View();
        }

        // CRUD?
    }
}
