namespace EGovernment.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PatientsController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        // CRUD?
    }
}
