using System.Threading.Tasks;

namespace EGovernment.Services.Data.EGovServicesServices
{
    public interface IEgovService
    {
        //show the user info by username
        T GetUserInformationByUserName<T>(string userName);

        Task<string> CreatePatientAsync(string firstName, string lastName, string egn, int addressId, int doctorId, int medicalRecordId); 

        // create Medical record here? 

    }
}
