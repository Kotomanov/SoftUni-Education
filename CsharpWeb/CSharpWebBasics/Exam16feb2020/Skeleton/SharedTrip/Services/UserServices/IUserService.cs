namespace SharedTrip.Services.UserServices
{
    public interface IUserService
    {
        string GetUserId(string username, string password);

        void Register(string username, string email, string password);

        bool UsernameExists(string username);

        bool EmailExists(string email);

        string GetUsername(string id);
    }
}
