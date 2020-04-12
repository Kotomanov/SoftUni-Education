namespace EGovernment.Services.Data.AddressServices
{
    using System.Collections.Generic;

    using EGovernment.Web.ViewModels.AppViewModels.AddressViewModels;

    public interface IAddressService
    {
        void CreateAddressAsync(InputAddressViewModel input);

        ICollection<DisplayAllAddressesViewModel> ListAllAddresses(); // get a collection here with what <>? - in foreach  in the View + table?

        void UpdateAsync();

        void DeleteAsync();

    }
}
