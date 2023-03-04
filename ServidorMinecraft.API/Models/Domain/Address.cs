namespace ServidorMinecraft.API.Models.Domain
{
    public class Address
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Block { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        //Navigation props
        public List<Work_Address> WorkAddresses { get; set; }
    }
}
