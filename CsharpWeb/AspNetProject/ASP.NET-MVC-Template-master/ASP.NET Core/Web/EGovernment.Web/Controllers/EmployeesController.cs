namespace EGovernment.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class EmployeesController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        // get the profile info 
        // get names, roles, manager
    }
}
