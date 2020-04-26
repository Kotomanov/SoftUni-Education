namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;

    using EGovernment.Services.Data.MedicalRecordsService;
    using Microsoft.AspNetCore.Mvc;

    public class MedicalRecordsController : BaseController
    {
        private readonly IMedicalRecordService service;

        public MedicalRecordsController(IMedicalRecordService service)
        {
            this.service = service;
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
            if (false)
            {
                this.TempData["Infomessage"] = "This patient already has a record";
                return this.Redirect("/Patients/PatientRecord");
            }

            await this.service.CreateRecordAsync();
            return this.Redirect("/MedicalRecords"); // add the id so it is set
        }
    }
}
