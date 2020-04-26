namespace EGovernment.Services.Data.MedicalRecordsService
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Models.Health;

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

        public void DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<T> GetAllRecords<T>()
        {
            throw new System.NotImplementedException();
        }

        public bool RecordExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
