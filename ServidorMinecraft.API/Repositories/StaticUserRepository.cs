using ServidorMinecraft.API.Models.Domain.Authentication;

namespace ServidorMinecraft.API.Repositories
{
    public class StaticUserRepository : IUserRepository
    {
        List<User> _users = new List<User>
        {
            new User
            {
                Username = "FelipeMinecraft",
                Password = "12341234",
                FirstName = "Felipe",
                LastName = "Ribeiro",
                EmailAddress = "felipeDoMine@gmail.com",
                Roles = new List<string>
                {
                    "create", "read", "update", "delete"
                }
            },
            new User
            {
                Username = "SpaceDiamond",
                Password = "royaldiamond",
                FirstName = "Space",
                LastName = "Gem",
                EmailAddress = "galaxygem02@gmail.com",
                Roles = new List<string>
                {
                    "read"
                }
            },
            new User
            {
                Username = "frame",
                Password = "flywallkill",
                FirstName = "Vitor",
                LastName = "Frame",
                EmailAddress = "avoante@gmail.com",
                Roles = new List<string> { }
            }
        };


        public Task<User> AuthenticateUserAsync(string username, string password)
        {
            return Task.FromResult(_users.FirstOrDefault(user => user.Username == username && user.Password == password));
        }
    }
}
