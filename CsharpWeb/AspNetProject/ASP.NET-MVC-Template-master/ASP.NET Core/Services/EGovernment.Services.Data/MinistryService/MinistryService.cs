namespace EGovernment.Services.Data.MinistryService
{
    using System.Collections.Generic;

    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Models.Health.Entities;
    using EGovernment.Web.ViewModels.AppViewModels.MinistriesViewModels;

    public class MinistryService : IMinistryService
    {
        private readonly IDeletableEntityRepository<Ministry> ministriesRepository;

        public MinistryService(
            IDeletableEntityRepository<Ministry> ministriesRepository,
            CreateMinistryInputModel input)
        {
            this.ministriesRepository = ministriesRepository;
        }

        public void CreateAsync(CreateMinistryInputModel input)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            throw new System.NotImplementedException();
        }

        public T GetByName<T>(string name)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAsync(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
