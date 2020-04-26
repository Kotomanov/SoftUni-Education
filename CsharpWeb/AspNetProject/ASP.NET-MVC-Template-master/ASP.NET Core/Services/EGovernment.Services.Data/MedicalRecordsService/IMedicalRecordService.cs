using System.Collections.Generic;
using System.Threading.Tasks;

namespace EGovernment.Services.Data.MedicalRecordsService
{
    public interface IMedicalRecordService
    {
        Task<int> CreateRecordAsync();

        bool RecordExists(int id);

        void DeleteAsync(int id);

        void UpdateAsync(int id);

        ICollection<T> GetAllRecords<T>();
    }
}
