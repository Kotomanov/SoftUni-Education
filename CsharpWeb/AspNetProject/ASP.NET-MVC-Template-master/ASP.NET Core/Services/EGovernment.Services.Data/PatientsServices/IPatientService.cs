namespace EGovernment.Services.Data.PatientsServices
{
    using System.Threading.Tasks;

    using EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels;

    public interface IPatientService
    {
        // create and return string id 
        bool PatientExists(string firstName, string lastName, string egn);

        Task<string> CreatePatientAsync(PatientUpdateInfoViewModel input);

        Task<string> GetPatientsIdAsync(string firstName, string lastName, string egn);

        T GetPatientById<T>(string id);

        // get by string id
        // update names for example
        // change gp 
        // set a profile to isdeleted true?
        // etc
        // add user to patient role

        // assign user to role patient
    }
}
