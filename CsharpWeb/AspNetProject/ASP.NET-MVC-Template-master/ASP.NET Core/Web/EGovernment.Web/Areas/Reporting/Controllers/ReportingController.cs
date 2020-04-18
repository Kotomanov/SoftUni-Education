namespace EGovernment.Web.Areas.Reporting.Controllers
{
    using EGovernment.Web.Controllers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    //[Authorize(Roles = "Administrator, Moderator, HeadOfDepartment")]
    [Area("Reporting")]
    public class ReportingController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
