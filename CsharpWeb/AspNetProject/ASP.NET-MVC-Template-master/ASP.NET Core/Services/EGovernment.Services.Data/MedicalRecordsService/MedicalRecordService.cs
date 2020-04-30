namespace EGovernment.Services.Data.MedicalRecordsService
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Models.Health;
    using EGovernment.Services.Mapping;

    public class MedicalRecordService : IMedicalRecordService
    {
        private readonly IDeletableEntityRepository<MedicalRecord> recordsRepository;

        public MedicalRecordService(IDeletableEntityRepository<MedicalRecord> recordsRepository)
        {
            this.recordsRepository = recordsRepository;
        }

        public async Task<int> CreateRecordAsync()
        {
            MedicalRecord record = new MedicalRecord();
            await this.recordsRepository.AddAsync(record);
            await this.recordsRepository.SaveChangesAsync();

            return record.Id;
        }

        public void Delete(int id)
        {
            var record = this.recordsRepository.All().Where(x => x.Id == id).First();
            if (record != null)
            {
                this.recordsRepository.Delete(record);
                this.recordsRepository.SaveChangesAsync();
            }
        }

        public ICollection<T> GetAllRecords<T>()
        {
            var records = this.recordsRepository.All().OrderBy(x => x.Id);
            return records.To<T>().ToList();
        }

        public bool RecordExists(int id)
        {
            var record = this.recordsRepository.All().Where(x => x.Id == id).FirstOrDefault();
            if (record == null)
            {
                return false;
            }

            return true;
        }

        public void UpdateAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
