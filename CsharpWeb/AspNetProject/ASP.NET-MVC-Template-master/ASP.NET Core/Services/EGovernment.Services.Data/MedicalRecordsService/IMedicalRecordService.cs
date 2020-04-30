namespace EGovernment.Services.Data.MedicalRecordsService
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMedicalRecordService
    {
        Task<int> CreateRecordAsync();

        bool RecordExists(int id);

        void Delete(int id);

        void UpdateAsync(int id);

        ICollection<T> GetAllRecords<T>();
    }
}
