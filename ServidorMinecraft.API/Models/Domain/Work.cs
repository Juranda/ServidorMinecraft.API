namespace ServidorMinecraft.API.Models.Domain
{
    public class Work
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        //Navigation props
        public List<Work_Address> WorkAddresses { get; set; }
    }
}
