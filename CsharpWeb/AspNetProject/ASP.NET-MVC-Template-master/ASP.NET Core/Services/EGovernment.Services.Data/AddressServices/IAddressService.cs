namespace EGovernment.Services.Data.AddressServices
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EGovernment.Web.ViewModels.AppViewModels.AddressViewModels;

    public interface IAddressService
    {
        Task<int> CreateAddressAsync(string countryName, string districtName, string cityName, int postalCode, string addressDetails);

        ICollection<T> GetAll<T>(); // get a collection here with what <>? - in foreach  in the View + table? this for the admin area?

        T GetAddressById<T>(int id);

        void UpdateAsync(int id);

        void DeleteAsync(int id); // for admin

        bool AddressExists(int id);

        bool CityExists(string name);

        ICollection<T> GetAllCountries<T>();

        ICollection<T> GetAllCities<T>();
    }
}
