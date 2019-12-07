using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        // Contract for register a user
         Task<User> Register(User user, string password);

        // Contract to login
         Task<User> Login(string username, string password);

        // Contract to see if user already exists in db
         Task<bool> UserExists(string username);
    }
}