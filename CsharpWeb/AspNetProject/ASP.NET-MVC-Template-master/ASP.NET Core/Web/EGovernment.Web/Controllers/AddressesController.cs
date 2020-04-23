namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;

    using AutoMapper;
    using EGovernment.Data;
    using EGovernment.Data.Models;
    using EGovernment.Data.Models.Enums;
    using EGovernment.Data.Models.Enums.Geography;
    using EGovernment.Services.Data.AddressServices;
    using EGovernment.Web.ViewModels.AppViewModels.AddressViewModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class AddressesController : BaseController
    {
        private readonly IAddressService service;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext db;

        public AddressesController(IAddressService service, UserManager<ApplicationUser> userManager, ApplicationDbContext db) // maybe usermanager?
        {
            this.service = service;
            this.userManager = userManager;
            this.db = db;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(InputAddressViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            if (((CountryCode)input.CountryId).ToString() == "Dummy"
                || ((DistrictCode)input.DistrictId).ToString() == "Dummy"
                || input.CityName.ToString() == "Dummy")
            {
                this.TempData["Infomessage"] = "Dummy is not a valid location";
                return this.View(input);
            }

            // city exists check from the service
            if (!this.service.CityExists(input.CityName))
            {
                this.TempData["Infomessage"] = "Enter a valid Bulgarian city name";
                return this.View(input);
            }

            await this.service.CreateAddressAsync(((CountryCode)input.CountryId).ToString(), ((DistrictCode)input.DistrictId).ToString(), input.CityName, input.PostalCode, input.AddressDetails);

            return this.Redirect("/Addresses/GetAll");
        }

        public async Task<IActionResult> GetAll()
        {
            var collection = this.service.GetAll<DisplayAllAddressesViewModel>();

            if (collection.Count == 0)
            {
                return this.NoContent();
            }

            AddressListDisplayViewModel list = new AddressListDisplayViewModel();
            list.AddressesList = collection;

            return this.View(list);
        }

        public IActionResult Delete()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            if (!this.ModelState.IsValid! || !this.service.AddressExists(id))
            {
                this.TempData["Infomessage"] = "Invalid Id entered.";
                return this.View(id);
            }

            this.service.DeleteAsync(id);
            this.TempData["Infomessage"] = "Address deleted.";
            return this.Redirect("/Addresses/GetAll");
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

            if (this.service.AddressExists(id))
            {
                var address = this.service.GetAddressById<DisplayAllAddressesViewModel>(id);
            }

            return this.View();
        }

        public async Task<IActionResult> FindById()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> FindById(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(id);
            }

            if (!this.service.AddressExists(id))
            {
                this.TempData["Infomessage"] = "Invalid Id entered.";
                return this.View(id);
            }

            var address = this.service.GetAddressById<DisplayAllAddressesViewModel>(id);

            return this.Redirect($"/Addresses/ShowSingleAddress?id={address.Id}");
        }

        public async Task<IActionResult> ShowSingleAddress(int id)
        {
            if (!this.service.AddressExists(id))
            {
                this.TempData["Infomessage"] = "Please search for a valid Id";
                return this.Redirect("/Addresses/FindById");
            }

            var address = this.service.GetAddressById<DisplayAllAddressesViewModel>(id);

            return this.View(address);
        }
    }
}
