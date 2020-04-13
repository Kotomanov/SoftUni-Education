namespace EGovernment.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class MinistriesController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult AllList()
        {
            return this.View();
        }


    }
}
