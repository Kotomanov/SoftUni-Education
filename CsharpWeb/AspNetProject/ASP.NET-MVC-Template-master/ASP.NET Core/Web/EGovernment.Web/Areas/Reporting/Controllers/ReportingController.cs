namespace EGovernment.Web.Areas.Reporting.Controllers
{
    using System.Threading.Tasks;

    using EGovernment.Data.Models;
    using EGovernment.Web.Controllers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    // [Authorize(Roles = "Administrator, Moderator, HeadOfDepartment")]
    // [Route("api/[controller]")]
    // [ApiController]
    // : ControllerBase
    [Area("Reporting")]
    [Authorize]
    public class ReportingController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public ReportingController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [AllowAnonymous] // or make Authorize here ..
        public IActionResult Index()
        {
            if (this.signInManager.IsSignedIn(this.User) && this.User.IsInRole("Administrator"))
            {
                this.TempData["Infomessage"] = "You already have the admin role. You can continue to reports";
                return this.Redirect("/Reporting/Reporting/ShowReportsPage");
            }
            return this.View();
        }

        public IActionResult AssignAdminRoleToUser()
        {
            if (!this.User.IsInRole("Administrator"))
            {
                return this.View();
            }

            this.TempData["Infomessage"] = "You already have the admin role. You can continue to reports";
            return this.Redirect("/Reporting/Reporting/ShowReportsPage");
        }

        [HttpPost]
        public async Task<IActionResult> AssignAdminRoleToUserAsync()
        {
            //if (this.User.IsInRole("Administrator"))
            //{
            //    this.TempData["Infomessage"] = "You already have the admin role. You can continue to reports";
            //    return this.Redirect("/Reporting/Reporting/ShowReportsPage");
            //}
            //else
            //{
            var user = await this.userManager.GetUserAsync(this.User);
            await this.userManager.AddToRoleAsync(user, "Administrator");
            this.TempData["Infomessage"] = "Admin role assigned. Enjoy!";
            return this.Redirect("/Reporting/Reporting/ShowReportsPage");
            //}
        }

        // see what and how to have access
        public IActionResult ShowReportsPage()
        {
            return this.View();
        }
    }
}
