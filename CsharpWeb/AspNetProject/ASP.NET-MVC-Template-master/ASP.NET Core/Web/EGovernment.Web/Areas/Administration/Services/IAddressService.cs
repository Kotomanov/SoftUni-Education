namespace EGovernment.Web.Areas.Administration.Services
{
    public interface IAddressService
    {
        void UpdateAsync(int id);

        void DeleteAsync(int id);

        bool AddressExists(int id);

        T GetAddressById<T>(int id);
    }
}
