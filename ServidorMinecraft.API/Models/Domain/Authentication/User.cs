namespace ServidorMinecraft.API.Models.Domain.Authentication
{
    public class User
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }

        public List<string> Roles { get; set; }

        //Navigation props
        List<Users_Roles> Users_Roles { get; set; }
    }
}
