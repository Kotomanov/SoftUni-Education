namespace EGovernment.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class EGovServicesController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
