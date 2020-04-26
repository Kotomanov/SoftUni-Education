using EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels;
using System.Threading.Tasks;

namespace EGovernment.Services.Data.PatientsServices
{
    public interface IPatientService
    {
        // create and return string id 
        bool PatientExists(string firstName, string lastName, string egn);

        Task<string> CreatePatientAsync(PatientUpdateInfoViewModel input);

        // get by string id
        // update names for example
        // change gp 
        // set a profile to isdeleted true?
        // etc
        // add user to patient role
    }
}
