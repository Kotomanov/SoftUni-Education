namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;

    using EGovernment.Data;
    using EGovernment.Data.Models;
    using EGovernment.Services.Data.EGovServicesServices;
    using EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class EGovServicesController : BaseController
    {
        private readonly IEgovService service;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;

        // maybe rolemanager

        public EGovServicesController(
            IEgovService service,
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext db)
        {
            this.service = service;
            this.userManager = userManager;
            this.db = db;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult SelectProfileSetOptions()
        {
            return this.View();
        }

        public IActionResult SetAccess(CombinedPatientViewModel combined)
        {
            combined.Input = this.service.GetUserInformationByUserName<PatientPersonalInfoViewModel>(this.User.Identity.Name);
            if (combined.Input == null)
            {
                this.TempData["Infomessage"] = this.NotFound();
                return this.Redirect("/Identity/Account/Login"); // not needed maybe?
            }

            return this.View(combined);
        }

        [HttpPost]
        public async Task<IActionResult> SetAccessAsync(CombinedPatientViewModel combined)
        {
            combined.Output.FirstName = combined.Input.FirstName;
            combined.Output.LastName = combined.Input.LastName;
            combined.Output.EGN = combined.Input.EGN;
            combined.Output.AddressId = combined.Input.AddressId;
            combined.Output.DoctorId = combined.Input.DoctorId;
            combined.Output.MedicalRecordId = combined.Input.MedicalRecordId;

            if (!this.ModelState.IsValid)
            {
                this.TempData["Infomessage"] = "Please verify the data input";
                return this.View(combined);
            }

            if (combined.Output.FirstName == "Dummy"
                || combined.Output.LastName == "Dummy"
                || combined.Output.AddressId < 0
                || combined.Output.DoctorId < 0
                || combined.Output.MedicalRecordId < 0
                || combined.Output.EGN.Length < 10
                || combined.Output.EGN.Length > 10
                || string.IsNullOrEmpty(combined.Output.FirstName)
                || string.IsNullOrEmpty(combined.Output.LastName)
                || string.IsNullOrEmpty(combined.Output.EGN))
            {
                this.TempData["Infomessage"] = "Please verify the data input";
                return this.View(combined);
            }

            if (this.service.PatientExists(combined.Output.FirstName, combined.Output.LastName, combined.Output.EGN))
            {
                // service to update the details of the patient
                return this.Redirect("/"); // to update the patient edit page - UpdatepatientProfile or move to next page?
            }

            await this.service.CreatePatientAsync(
               combined.Output.FirstName,
               combined.Output.LastName,
               combined.Output.EGN,
               combined.Output.AddressId,
               combined.Output.DoctorId,
               combined.Output.MedicalRecordId);

            return this.View(combined); // to update adress, GP, Record or do that before the patient creation
        }

        public IActionResult UpdatePatientProfile() // input model
        {
            return this.View();
        }
    }
}
