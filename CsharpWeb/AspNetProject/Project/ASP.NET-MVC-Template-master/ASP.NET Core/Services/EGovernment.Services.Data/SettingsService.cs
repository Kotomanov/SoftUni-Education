using EGovernment.Services.Mapping;

namespace EGovernment.Services.Data
{
    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.All().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
