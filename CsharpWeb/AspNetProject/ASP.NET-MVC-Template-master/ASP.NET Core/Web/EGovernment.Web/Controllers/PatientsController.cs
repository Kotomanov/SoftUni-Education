namespace EGovernment.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using EGovernment.Data.Models;
    using EGovernment.Services.Data.PatientsServices;
    using EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class PatientsController : BaseController
    {
        private readonly IPatientService patientService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public PatientsController(
            IPatientService patientService,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            this.patientService = patientService;
            this.userManager = userManager;
            this.roleManager = roleManager;
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

            var user = await this.userManager.GetUserAsync(this.User);
            await this.userManager.AddToRoleAsync(user, "Patient");

            return this.Redirect("/EGovServices/SelectProfileSetOptions");
        }

        public IActionResult PatientRecord() // string patientId
        {
            string id = this.TempData["PatientId"].ToString();
            DisplayPatientBasicInfoViewModel result = this.patientService.GetPatientById<DisplayPatientBasicInfoViewModel>(id);
            return this.View(result);
        }

        public IActionResult UpdatePatientRecord() // viewmodel to display the details
        {
            return this.View();
        }

        // CRUD?
    }
}
