namespace EGovernment.Services.Data.Heath
{
    public interface IHealthService
    {
        // retrieve the names, email, email/username, phoneNumber
        // get the names of the user

        T GetNamesById<T>(string id);
    }
}
