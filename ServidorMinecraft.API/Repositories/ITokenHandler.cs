using ServidorMinecraft.API.Models.Domain.Authentication;

namespace ServidorMinecraft.API.Repositories
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(User user);
    }
}
