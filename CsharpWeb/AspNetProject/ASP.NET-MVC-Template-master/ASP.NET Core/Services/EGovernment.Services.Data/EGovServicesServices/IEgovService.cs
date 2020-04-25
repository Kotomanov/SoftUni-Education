using System.Threading.Tasks;

namespace EGovernment.Services.Data.EGovServicesServices
{
    public interface IEgovService
    {
        //show the user info by username
        T GetUserInformationByUserName<T>(string userName);

        Task<string> CreatePatientAsync(string firstName, string lastName, string egn, int addressId, int doctorId, int medicalRecordId);

        // create Medical record here?

        // if patient exists do not create again - how to update the details under te same patient ID
        bool PatientExists(string userFirstName, string userLastName, string egn);

        string GetPatientId(string firstName, string lastName, string egn);

        T GetPatientdetails<T>(string patientId);

        Task<int> CreateMedicalRecordAsync();
    }
}
