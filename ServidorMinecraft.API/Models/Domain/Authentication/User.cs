using System.ComponentModel.DataAnnotations.Schema;

namespace ServidorMinecraft.API.Models.Domain.Authentication
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }

        [NotMapped]
        public List<string> Roles { get; set; }

        //Navigation props
        public List<Users_Roles> Users_Roles { get; set; }
    }
}
