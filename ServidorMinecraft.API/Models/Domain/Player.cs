namespace ServidorMinecraft.API.Models.Domain
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Money { get; set; }
        public DateTime FirstLogginDate { get; set; }

        public Guid WorkId { get; set; }

        //Navigation props
        public Work Work { get; set; }
        public IEnumerable<Pet> Pets { get; set; }
    }
}
