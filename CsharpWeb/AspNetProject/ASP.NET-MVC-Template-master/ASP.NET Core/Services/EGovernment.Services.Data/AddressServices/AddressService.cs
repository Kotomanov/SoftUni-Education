namespace EGovernment.Services.Data.AddressServices
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class AddressService : IAddressService
    {
        private readonly IDeletableEntityRepository<Address> addressRepository;
        private readonly IDeletableEntityRepository<City> citiesRepository;
        private readonly IDeletableEntityRepository<Country> countriesRepository;

        public AddressService(
            IDeletableEntityRepository<Address> addressRepository,
            IDeletableEntityRepository<City> citiesRepository,
            IDeletableEntityRepository<Country> countriesRepository)
        {
            this.addressRepository = addressRepository;
            this.citiesRepository = citiesRepository;
            this.countriesRepository = countriesRepository;
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

        public void DeleteAsync(int id) // for admin only
        {
            var address = this.addressRepository.All().Where(x => x.Id == id).FirstOrDefault();
            if (address != null)
            {
                this.addressRepository.Delete(address);
                this.addressRepository.SaveChangesAsync();
            }
        }

        public bool AddressExists(int id)
        {
            var address = this.addressRepository.All().Where(x => x.Id == id).FirstOrDefault();
            if (address == null)
            {
                return false;
            }

            return true;
        }

        public ICollection<T> GetAll<T>()
        {
            var addresses = this.addressRepository.All()
                .OrderBy(a => a.CountryName)
                .ThenBy(a => a.DistrictName)
                .ThenBy(a => a.CityName);

            return addresses.To<T>().ToList();
        }

        public T GetAddressById<T>(int id)
        {
            var address = this.addressRepository.All().Where(x => x.Id == id);
            return address.To<T>().First();
        }

        public void UpdateAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool CityExists(string name)
        {
            var city = this.citiesRepository.All().Where(x => x.Name.ToLower() != "dummy" && x.Name == name).FirstOrDefault();

            if (city == null)
            {
                return false;
            }

            return true;
        }

    }
}
