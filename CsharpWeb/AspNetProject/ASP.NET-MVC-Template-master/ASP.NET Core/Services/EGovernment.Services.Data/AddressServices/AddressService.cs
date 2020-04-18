namespace EGovernment.Services.Data.AddressServices
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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

        public async Task<int> CreateAddressAsync(string countryName, string districtName, string cityName, int postalCode, string addressDetails)
        {
            Address address = new Address
            {
                CountryName = countryName,
                DistrictName = districtName,
                CityName = cityName,
                PostalCode = postalCode,
                AddressDetails = addressDetails,
            };

            await this.addressRepository.AddAsync(address);
            await this.addressRepository.SaveChangesAsync();

            return address.Id;
        }

        public void DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<T> GetAll<T>()
        {
            throw new System.NotImplementedException();
        }

        public T GetById<T>(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
