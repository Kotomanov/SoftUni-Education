namespace EGovernment.Web.Areas.Reporting.Controllers
{
    using System.Threading.Tasks;

    using EGovernment.Data.Models;
    using EGovernment.Web.Areas.Reporting.Services;
    using EGovernment.Web.Areas.Reporting.ViewModels;
    using EGovernment.Web.Controllers;
    using EGovernment.Web.ViewModels.AppViewModels.AddressViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    // [Route("api/[controller]")]
    // [ApiController]
    // : ControllerBase
    [Area("Reporting")]
    [Authorize]
    public class ReportingController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IReportService service;

        public ReportingController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IReportService service)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.service = service;
        }

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
            var user = await this.userManager.GetUserAsync(this.User);
            await this.userManager.AddToRoleAsync(user, "Administrator");
            this.TempData["Infomessage"] = "Admin role assigned. Enjoy!";
            return this.Redirect("/Reporting/Reporting/ShowReportsPage");
        }

        // see what and how to have access
        public IActionResult ShowReportsPage()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> ShowReportsPageAsync()
        {
            return this.Redirect("/Reporting/Reporting/ShowAddressReport");
        }

        public IActionResult ShowAddressReports()
        {
            return this.View();
        }

        public IActionResult ShowAddressByCountry()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> ShowAddressByCountry(SearchByCountryViewModel name)
        {
            // if empty - nothing to show
            var collection = this.service.GetAllAddresses<DisplayAllAddressesViewModel>(name.CountryName);

            if (collection.Count == 0)
            {
                this.TempData["Infomessage"] = "No data available for this criteria";
                return this.Redirect("/Reporting/Reporting/ShowReportsPage");
            }

            AddressListDisplayViewModel list = new AddressListDisplayViewModel();
            list.AddressesList = collection;

            //feeding the data?

            return this.Redirect("/Reporting/Reporting/DisplayResultsByCountry");
        }

        public IActionResult DisplayResultsByCountry(AddressListDisplayViewModel model)
        {
            if (model.AddressesList == null)
            {
                this.TempData["Infomessage"] = "No data available for this criteria";
                return this.Redirect("/Reporting/Reporting/ShowReportsPage");
            }

            return this.View(model);
        }
    }
}
