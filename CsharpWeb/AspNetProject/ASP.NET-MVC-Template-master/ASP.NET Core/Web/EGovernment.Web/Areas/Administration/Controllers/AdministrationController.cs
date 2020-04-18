namespace EGovernment.Web.Areas.Administration.Controllers
{
    using EGovernment.Common;
    using EGovernment.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    //[Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        // add here the address, users, etc items 
    }
}
