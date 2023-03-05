namespace ServidorMinecraft.API.Models.Domain.Authentication
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        //Navigation props
        public List<Users_Roles> Users_Roles { get; set; }
    }
}
