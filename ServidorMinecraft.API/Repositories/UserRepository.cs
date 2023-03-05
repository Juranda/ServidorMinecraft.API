using Microsoft.EntityFrameworkCore;
using ServidorMinecraft.API.Data;
using ServidorMinecraft.API.Models.Domain.Authentication;

namespace ServidorMinecraft.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MinecraftServerDbContext context;

        public UserRepository(MinecraftServerDbContext context)
        {
            this.context = context;
        }

        public async Task<User> AuthenticateUserAsync(string username, string password)
        {
            return await context.Users.FirstOrDefaultAsync(user => user.Username == username && user.Password == password);
        }
    }
}
