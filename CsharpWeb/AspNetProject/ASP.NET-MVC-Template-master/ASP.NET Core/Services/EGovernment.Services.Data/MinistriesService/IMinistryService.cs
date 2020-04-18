namespace EGovernment.Services.Data.MinistryService
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMinistryService
    {
        Task<int> CreateAsync(string name, int addressId, string pictureLink, string url, int ministryCode); // CreateMinistryInputModel input

        ICollection<T> GetAll<T>(); // int? take = null, int skip = 0 for the pagination maybe?

        T GetByName<T>(string name); // ? <T>

        void DeleteAsync(string name);

        bool Exists(string name);
    }
}
