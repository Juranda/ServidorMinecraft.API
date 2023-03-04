namespace ServidorMinecraft.API.Models.Domain
{
    public class Work_Address
    {
        public Guid Id { get; set; }

        public Guid WorkId { get; set; }
        public Guid AddressId { get; set; }
    
        //Navigation props
        public Work Work { get; set; }
        public Address Address { get; set; }
    }
}
