namespace EGovernment.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HealthController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        //Task? Async, await
        public IActionResult PatientRecord()
        {
            return this.View();
        }

        //httppost 

        //Edit Health Recoird - Doctor only , 

        //add user to role 

        //see the list of roles with get get(form) + post  input data

        // sendgrid somehow? will see

        //


    }
}
