namespace EGovernment.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using EGovernment.Data;
    using EGovernment.Data.Models;
    using EGovernment.Services.Data.AddressServices;
    using EGovernment.Web.Controllers;
    using EGovernment.Web.ViewModels.AppViewModels.AddressViewModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Area("Administration")]
    public class AddressesController : BaseController
    {
        private readonly IAddressService service;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;

        public AddressesController(
            IAddressService service,
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext db) // maybe usermanager?
        {
            this.service = service;
            this.userManager = userManager;
            this.db = db;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Delete()
        {
            return this.View();
        }

        [HttpPost]
        // [Authorize(Roles = "Administrator")] or move to admin part?
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (!this.ModelState.IsValid! || !this.service.AddressExists(id) || !this.db.Addresses.Any(x => x.Id == id))
            {
                this.TempData["Infomessage"] = "Invalid Id entered.";
                return this.View(id);
            }

            var address = this.db.Addresses.Where(x => x.Id == id).First();
            this.db.Remove(address);
            await this.db.SaveChangesAsync();
            this.service.DeleteAsync(id);
            this.TempData["Infomessage"] = "Address deleted.";
            return this.Redirect("/Administration/Addresses/Index");
        }

        public async Task<IActionResult> Update()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(id);
            }

            if (!this.service.AddressExists(id))
            {
                this.TempData["Infomessage"] = "Invalid address.";
                return this.View(id);
            }

            var address = this.service.GetAddressById<DisplayAllAddressesViewModel>(id);

            return this.View(address);
        }

        public async Task<IActionResult> FindById()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> FindById(SearchAddressByIdViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            if (!this.service.AddressExists(input.Id))
            {
                this.TempData["Infomessage"] = "Invalid Id entered.";
                return this.View(input);
            }

            var address = this.service.GetAddressById<DisplayAllAddressesViewModel>(input.Id);

            return this.Redirect($"/Administration/Addresses/ShowSingleAddress?id={address.Id}");
        }


        public async Task<IActionResult> ShowSingleAddress(int id)
        {
            if (!this.service.AddressExists(id))
            {
                this.TempData["Infomessage"] = "Please search for a valid Id";
                return this.Redirect("/Administration/Addresses/FindById");
            }

            var address = this.service.GetAddressById<DisplayAllAddressesViewModel>(id);

            return this.View(address);
        }
    }
}
