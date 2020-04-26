using System.Collections.Generic;

namespace EGovernment.Services.Data.DoctorsService
{
    public interface IDoctorService
    {
        // check if exists
        // create ->  Task<int> CreateDoctorAsync(string firstName, string lastName, string egn);
        // delete
        // find by id -> T GetDoctorById<T>(int id);
        // doctor exists
        // find by names or only by ID
        // getall -> ICollection<T> GetAll<T>();

        ICollection<T> GetAllDoctors<T>();

        bool DoctorExists(string firstName, string lastName);

        T GetDoctorById<T>(int id);

        T GetDoctorByNames<T>(string firstName, string lastName);
    }
}
