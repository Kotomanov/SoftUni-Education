namespace EGovernment.Web.Controllers
{
    using System.Threading.Tasks;

    using EGovernment.Data.Models;
    using EGovernment.Services.Data.AddressServices;
    using EGovernment.Web.ViewModels.AppViewModels.AddressViewModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class AddressesController : BaseController
    {
        private readonly IAddressService service;
        private readonly UserManager<ApplicationUser> userManager;

        public AddressesController(IAddressService service, UserManager<ApplicationUser> userManager) // maybe usermanager?
        {
            this.service = service;
            this.userManager = userManager;
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

            await this.service.CreateAddressAsync(input.CountryName, input.DistrictName, input.CityName, input.PostalCode, input.AddressDetails);

            return default; // return this.RedirectToAction(nameof(this.ById), new { id = postId }); ---GetById
        }

        public IActionResult GetAll() // maybe not Task async?
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
    }
}
