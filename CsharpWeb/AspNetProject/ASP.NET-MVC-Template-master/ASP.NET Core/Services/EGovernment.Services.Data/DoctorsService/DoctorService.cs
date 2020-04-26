namespace EGovernment.Services.Data.DoctorsService
{
    using System.Collections.Generic;
    using System.Linq;

    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Models.People;
    using EGovernment.Services.Mapping;

    public class DoctorService : IDoctorService
    {
        private readonly IDeletableEntityRepository<Doctor> doctorRepository;

        public DoctorService(IDeletableEntityRepository<Doctor> doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }

        public bool DoctorExists(string firstName, string lastName)
        {
            return this.doctorRepository.All().Any(x => x.FirstName == firstName && x.LastName == lastName);
        }

        public ICollection<T> GetAllDoctors<T>()
        {
            var doctors = this.doctorRepository.All()
                .OrderBy(d => d.FirstName)
                .ThenBy(d => d.LastName);

            return doctors.To<T>().ToList();
        }

        public T GetDoctorById<T>(int id)
        {
            var doctor = this.doctorRepository.All().Where(x => x.Id == id);
            return doctor.To<T>().First();
        }

        public T GetDoctorByNames<T>(string firstName, string lastName)
        {
            var doctor = this.doctorRepository.All().Where(x => x.FirstName == firstName && x.LastName == lastName);
            return doctor.To<T>().First();
        }
    }
}
