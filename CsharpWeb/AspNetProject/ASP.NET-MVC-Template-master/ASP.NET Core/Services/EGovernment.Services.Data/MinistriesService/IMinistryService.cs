namespace EGovernment.Services.Data.MinistryService
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMinistryService
    {
        Task<int> CreateAsync(string name, int addressId, string pictureLink, string url, int ministryCode); // CreateMinistryInputModel input

        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);

        void DeleteAsync(string name);

        bool Exists(string name);
    }
}
