namespace EGovernment.Services.Data.MinistryService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Enums.Entities;
    using EGovernment.Data.Models.Models.Health.Entities;

    public class MinistryService : IMinistryService
    {
        private readonly IDeletableEntityRepository<Ministry> ministriesRepository;

        public MinistryService(
            IDeletableEntityRepository<Ministry> ministriesRepository)
        {
            this.ministriesRepository = ministriesRepository;
        }

        public async Task<int> CreateAsync(string name, int addressId, string pictureLink, string url, int ministryCode)
        {
            var newMinistry = new Ministry
            {
                Name = name,
                AddressId = addressId,
                MinistryCode = (MinistryCode)ministryCode,
                PictureLink = pictureLink,
                Url = url,
            };
            await this.ministriesRepository.AddAsync(newMinistry);
            await this.ministriesRepository.SaveChangesAsync();
            return newMinistry.Id;
        }

        public void DeleteAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool Exists(string name)
        {
            IQueryable ministry = this.ministriesRepository.All().Where(x => x.Name == name);

            if (ministry == null)
            {
                return false;
            }

            return true;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            return default;
        }

        public T GetByName<T>(string name)
        {
            return default;
        }

        public void UpdateAsync(string name)
        {

        }
    }
}
