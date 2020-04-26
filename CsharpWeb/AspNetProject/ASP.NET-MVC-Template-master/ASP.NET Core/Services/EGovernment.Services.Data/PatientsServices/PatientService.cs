namespace EGovernment.Services.Data.PatientsServices
{
    using System.Linq;
    using System.Threading.Tasks;
    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Models.People;
    using EGovernment.Web.ViewModels.AppViewModels.PatientsViewModels;

    public class PatientService : IPatientService
    {
        private readonly IDeletableEntityRepository<Patient> patientRepository;

        public PatientService(IDeletableEntityRepository<Patient> patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        public async Task<string> CreatePatientAsync(PatientUpdateInfoViewModel input)
        {
            Patient patient = new Patient
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                EGN = input.EGN,
                AddressId = input.AddressId,
                DoctorId = input.DoctorId,
                MedicalRecordId = input.MedicalRecordId,
            };

            await this.patientRepository.AddAsync(patient);
            await this.patientRepository.SaveChangesAsync();

            return patient.Id;
        }

        public bool PatientExists(string firstName, string lastName, string egn)
        {
            if (!this.patientRepository.All().Where(x => x.FirstName == firstName && x.LastName == lastName && x.EGN == egn).Any())
            {
                return false;
            }

            return true;
        }
    }
}
