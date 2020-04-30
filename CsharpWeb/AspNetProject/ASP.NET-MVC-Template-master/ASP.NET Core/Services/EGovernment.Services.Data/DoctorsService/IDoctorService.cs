namespace EGovernment.Services.Data.DoctorsService
{
    using System.Collections.Generic;

    public interface IDoctorService
    {
        // create ->  Task<int> CreateDoctorAsync(string firstName, string lastName, string egn);
        // delete

        ICollection<T> GetAllDoctors<T>();

        bool DoctorExists(string firstName, string lastName);

        T GetDoctorById<T>(int id);

        T GetDoctorByNames<T>(string firstName, string lastName);
    }
}
