namespace EGovernment.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class UnderConstructionController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}