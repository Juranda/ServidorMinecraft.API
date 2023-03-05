namespace ServidorMinecraft.API.Models.Domain.Authentication
{
    public class Users_Roles
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        //Navigation props
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
