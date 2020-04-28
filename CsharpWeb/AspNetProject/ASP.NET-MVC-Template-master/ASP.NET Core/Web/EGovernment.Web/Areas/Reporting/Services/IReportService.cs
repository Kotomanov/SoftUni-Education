namespace EGovernment.Web.Areas.Reporting.Services
{
    using System.Collections.Generic;

    public interface IReportService
    {
        ICollection<T> GetAllPatients<T>();

        ICollection<T> GetAllAddresses<T>(string countryName);

        ICollection<T> GetAllDoctors<T>();
    }
}
