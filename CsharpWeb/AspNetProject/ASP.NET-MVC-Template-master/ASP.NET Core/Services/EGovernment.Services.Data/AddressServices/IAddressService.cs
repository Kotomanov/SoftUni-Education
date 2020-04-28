namespace EGovernment.Services.Data.AddressServices
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAddressService
    {
        Task<int> CreateAddressAsync(string countryName, string districtName, string cityName, int postalCode, string addressDetails);

        ICollection<T> GetAll<T>();

        T GetAddressById<T>(int id);

        void UpdateAsync(int id);

        void DeleteAsync(int id);

        bool AddressExists(int id);

        bool CityExists(string name);
    }
}
