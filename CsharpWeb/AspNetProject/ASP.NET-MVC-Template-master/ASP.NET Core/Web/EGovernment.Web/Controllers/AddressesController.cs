namespace EGovernment.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class AddressesController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Create()
        {
            return this.View();
        }
    }
}
