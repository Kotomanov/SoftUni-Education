namespace EGovernment.Web.Areas.Reporting.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using EGovernment.Data.Common.Repositories;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Data.Models.Models.People;
    using EGovernment.Services.Mapping;

    public class ReportService : IReportService
    {
        private readonly IDeletableEntityRepository<Address> addressRepository;
        private readonly IDeletableEntityRepository<Patient> patientRepository;

        public ReportService(
            IDeletableEntityRepository<Address> addressRepository,
            IDeletableEntityRepository<Patient> patientRepository)
        {
            this.addressRepository = addressRepository;
            this.patientRepository = patientRepository;
        }

        public ICollection<T> GetAllAddresses<T>(string name)
        {
            var addresses = this.addressRepository.All()
                .Where(x => x.CountryName == name)
                .OrderBy(a => a.CountryName)
                .ThenBy(a => a.DistrictName)
                .ThenBy(a => a.CityName);

            return addresses.To<T>().ToList();
        }

        public ICollection<T> GetAllDoctors<T>()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<T> GetAllPatients<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}
