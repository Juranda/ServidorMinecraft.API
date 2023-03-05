using ServidorMinecraft.API.Models.Domain.Authentication;

namespace ServidorMinecraft.API.Repositories
{
    public interface IUserRepository
    {
        Task<User> AuthenticateUserAsync(string username, string password);
    }
}
