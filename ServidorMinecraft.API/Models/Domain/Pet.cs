namespace ServidorMinecraft.API.Models.Domain
{
    public class Pet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BornDate { get; set; }

        public Guid PlayerId { get; set; }
        public Guid AddressId { get; set; }
        public Guid PetTypeId { get; set; }

        //Navigation props
        public Player Player { get; set; }
        public Address Address { get; set; }
        public PetType PetType { get; set; }
    }
}
