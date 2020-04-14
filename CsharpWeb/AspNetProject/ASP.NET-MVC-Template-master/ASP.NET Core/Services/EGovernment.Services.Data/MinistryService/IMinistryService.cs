namespace EGovernment.Services.Data.MinistryService
{
    using System.Collections.Generic;

    using EGovernment.Web.ViewModels.AppViewModels.MinistriesViewModels;

    public interface IMinistryService
    {
        void CreateAsync(CreateMinistryInputModel input);

        IEnumerable<T> GetAll<T>(int? count = null);

        T GetByName<T>(string name);

        void UpdateAsync(string name);

        void DeleteAsync(string name);
    }
}
