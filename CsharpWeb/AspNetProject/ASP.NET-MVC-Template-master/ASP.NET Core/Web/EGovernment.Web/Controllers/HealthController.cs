namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;
    using EGovernment.Data.Models;
    using EGovernment.Services.Data.PatientsServices;
    using EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class HealthController : BaseController
    {
        private readonly IPatientService patientService;
        private readonly UserManager<ApplicationUser> userManager;

        public HealthController(
            IPatientService patientService,
            UserManager<ApplicationUser> userManager)
        {
            this.patientService = patientService;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        // Task? Async, await
        public IActionResult PatientRecord()
        {
            return this.View();
        }

        public IActionResult Profile()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> ProfileAsync(CheckPatientStatusViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                this.TempData["Infomessage"] = "Please verify the input";
                return this.View(input);
            }

            if (!this.patientService.PatientExists(input.FirstName, input.LastName, input.EGN))
            {
                this.TempData["Infomessage"] = "Please register your medical profile";
                return this.Redirect("/Patients/Create");
            }

            // TODO add a check on the input vs user names and egn, so does not register and checks for other people
            if (this.patientService.PatientExists(input.FirstName, input.LastName, input.EGN))
            {
                string patientId = await this.patientService.GetPatientsIdAsync(input.FirstName, input.LastName, input.EGN);

                this.TempData["Infomessage"] = "Your medical profile exists";
                this.TempData["PatientId"] = patientId;
                return this.Redirect("/Patients/PatientRecord"); // check here id = {patientId}
            }

            return this.View(input);
        }

        //httppost 

        //Edit Health Recoird - Doctor only , 

        //add user to role 

        //see the list of roles with get get(form) + post  input data

        // sendgrid somehow? will see

        //


    }
}
