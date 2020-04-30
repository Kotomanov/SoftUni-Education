namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;
    using EGovernment.Data;
    using EGovernment.Data.Models;
    using EGovernment.Services.Data.MedicalRecordsService;
    using EGovernment.Services.Data.PatientsServices;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class MedicalRecordsController : BaseController
    {
        private readonly IMedicalRecordService service;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;
        private readonly IPatientService patientService;

        public MedicalRecordsController(
            IMedicalRecordService service,
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext db,
            IPatientService patientService)
        {
            this.service = service;
            this.userManager = userManager;
            this.db = db;
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
        public async Task<IActionResult> CreateAsync()
        {
            // check if the patient already has such record
            // if has it , bach with the eror
            if ()
            {
                this.TempData["Infomessage"] = "This patient already has a record";
                return this.Redirect("/Patients/PatientRecord");
            }

            int record = await this.service.CreateRecordAsync(); // see if in the view to add it ?!
            return this.Redirect("/MedicalRecords"); // add the id so it is set ?id-
        }
    }
}
