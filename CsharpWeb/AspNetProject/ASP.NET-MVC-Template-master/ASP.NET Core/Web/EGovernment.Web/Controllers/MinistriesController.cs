namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;

    using EGovernment.Data.Models;
    using EGovernment.Services.Data.MinistryService;
    using EGovernment.Web.ViewModels.AppViewModels.MinistriesViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class MinistriesController : BaseController
    {
        private readonly IMinistryService service;
        private readonly UserManager<ApplicationUser> userManager;

        public MinistriesController(IMinistryService service, UserManager<ApplicationUser> userManager)
        {
            this.service = service;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult AllList()
        {
            var ministries = this.service.GetAll<DisplayAllMinistriesList>();
            if (ministries.Count == 0)
            {
                return this.NoContent();
            }

            MinistriesCollectionViewModel view = new MinistriesCollectionViewModel();
            view.MinistriesList = ministries;

            return this.View(view);
        }

        // [Authorize(Roles = "Administrator, Moderator, Magician")]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        // [Authorize(Roles = "Administrator, Moderator, Magician")]
        public async Task<IActionResult> Create(CreateMinistryInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            if (this.service.Exists(inputModel.Name))
            {
                this.TempData["Infomessage"] = "This ministry exists";
                return this.View(inputModel);
            }

            await this.service.CreateAsync(
                    inputModel.Name,
                    inputModel.AddressId,
                    inputModel.PictureLink,
                    inputModel.Url,
                    inputModel.MinistryCode
                    );
            this.TempData["Infomessage"] = "New ministry has been registered";
            return this.RedirectToAction("/AllList");
        }

       // [Authorize(Roles = "Administrator, Moderator, Magician")]
        public IActionResult Delete(string name)
        {
            return this.View();
        }
    }
}
