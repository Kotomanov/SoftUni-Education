namespace EGovernment.Services.Data.EGovServicesServices
{
    using System.Linq;
    using System.Threading.Tasks;
    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models;
    using EGovernment.Data.Models.Models.People;
    using EGovernment.Services.Mapping;
    using Microsoft.AspNetCore.Identity;

    public class EgovService : IEgovService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly IDeletableEntityRepository<Patient> patientRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public EgovService(
            IDeletableEntityRepository<ApplicationUser> userRepository,
            IDeletableEntityRepository<Patient> patientRepository,
            UserManager<ApplicationUser> userManager)
        {
            this.userRepository = userRepository;
            this.patientRepository = patientRepository;
            this.userManager = userManager;
        }

        public Task<int> CreateMedicalRecordAsync()
        {
            // if the patient does not have such
            // assign the record number to the patient
            throw new System.NotImplementedException();
        }

        public async Task<string> CreatePatientAsync(string firstName, string lastName, string egn, int addressId, int doctorId, int medicalRecordId)
        {
            Patient patient = new Patient
            {
                FirstName = firstName,
                LastName = lastName,
                EGN = egn,
                AddressId = addressId,
                DoctorId = doctorId,
                MedicalRecordId = medicalRecordId,
            };

            await this.patientRepository.AddAsync(patient);
            await this.patientRepository.SaveChangesAsync();

            return patient.Id;
        }

        public T GetPatientdetails<T>(string patientId)
        {
            var patient = this.patientRepository.All().Where(x => x.Id == patientId);
            return patient.To<T>().First();
        }

        public string GetPatientId(string firstName, string lastName, string egn)
        {
            if (this.PatientExists(firstName, lastName, egn))
            {
                var patient = this.patientRepository.All().Where(x => x.FirstName == firstName && x.LastName == lastName && x.EGN == egn).First().Id;
                return patient;
            }

            return null;
        }

        public T GetUserInformationByUserName<T>(string userName)
        {
            var userDetails = this.userRepository.All().Where(x => x.UserName == userName);
            return userDetails.To<T>().First();
        }

        public bool PatientExists(string userFirstName, string userLastName, string egn)
        {
            var patient = this.patientRepository.All().Where(x => x.FirstName == userFirstName && x.LastName == userLastName && x.EGN == egn).First();

            if (patient != null)
            {
                return true;
            }

            return false;
        }
    }
}
