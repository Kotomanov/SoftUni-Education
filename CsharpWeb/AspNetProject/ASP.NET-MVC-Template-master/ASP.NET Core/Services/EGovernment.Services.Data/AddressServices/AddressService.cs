namespace EGovernment.Services.Data.AddressServices
{
    using System.Collections.Generic;
    using System.Linq;

    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Web.ViewModels.AppViewModels.AddressViewModels;

    public class AddressService : IAddressService
    {
        private readonly IDeletableEntityRepository<Address> addressRepository;

        public AddressService(IDeletableEntityRepository<Address> addressRepository)
        {
            this.addressRepository = addressRepository;
        }

        public void CreateAddressAsync(InputAddressViewModel input)
        {
            var addressCheck = this.addressRepository.All().Where(a => a.AddressDetails == input.AddressDetails);

            if (addressCheck != null)
            {
            }
        }

        public void DeleteAsync()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<DisplayAllAddressesViewModel> ListAllAddresses()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
