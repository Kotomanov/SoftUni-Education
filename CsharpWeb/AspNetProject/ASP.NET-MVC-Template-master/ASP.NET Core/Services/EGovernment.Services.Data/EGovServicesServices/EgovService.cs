namespace EGovernment.Services.Data.EGovServicesServices
{
    using System.Linq;
    using System.Threading.Tasks;
    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models;
    using EGovernment.Data.Models.Models.People;
    using EGovernment.Services.Mapping;

    public class EgovService : IEgovService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly IDeletableEntityRepository<Patient> patientRepository;

        public EgovService(IDeletableEntityRepository<ApplicationUser> userRepository, 
            IDeletableEntityRepository<Patient> patientRepository)
        {
            this.userRepository = userRepository;
            this.patientRepository = patientRepository;
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

        public T GetUserInformationByUserName<T>(string userName)
        {
            var userDetails = this.userRepository.All().Where(x => x.UserName == userName);
            return userDetails.To<T>().First();
        }
    }
}
