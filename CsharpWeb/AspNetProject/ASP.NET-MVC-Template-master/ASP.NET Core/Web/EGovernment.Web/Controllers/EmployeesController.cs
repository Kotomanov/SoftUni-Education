namespace EGovernment.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class EmployeesController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult ProfilePage()
        {
            return this.View();
        }

        public IActionResult Roles()
        {
            return this.View();
        }

        public IActionResult RequestADocument()
        {
            return this.View();
        }

        // get the profile info 
        // get names, roles, manager
    }
}
