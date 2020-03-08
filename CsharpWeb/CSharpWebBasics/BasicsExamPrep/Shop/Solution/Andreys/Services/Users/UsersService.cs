using Andreys.Data;
using Andreys.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Andreys.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly AndreysDbContext db;
        public UsersService(AndreysDbContext db)
        {
            this.db = db;
        }

        public bool EmailExists(string email)
        {
            return db.Users.Any(u => u.Email == email);

        }

        public string GetUserId(string username, string password)
        {
            var hashedPass = this.HashPassword(password);

            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == hashedPass);

            if (user == null)
            {
                return null;
            }
            return user.Id;
        }

        public string GetUsername(string id)
        {
            var user = this.db.Users
                              .Where(u => u.Id == id)
                              .Select(u => u.Username)
                              .FirstOrDefault();

            return user;
        }

        public void Register(string username, string email, string password)
        {
            var user = new User()
            {
                Username = username,
                Email = email,
                Password = this.HashPassword(password),

            };

            this.db.Users.Add(user);
            this.db.SaveChanges();
        }

        public bool UsernameExists(string username)
        {
            var user = this.db.Users
                         .Where(u => u.Username == username)
                         .FirstOrDefault();
            if (user == null)
            {
                return false;
            }

            return true;
        }

        private string HashPassword(string inputPassword)
        {

            if (inputPassword == null)
            {
                return null;
            }

            var crypt = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));

            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }

            return hash.ToString();

        }


    }
}
