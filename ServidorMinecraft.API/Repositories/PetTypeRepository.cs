using ServidorMinecraft.API.Models.Domain;

namespace ServidorMinecraft.API.Repositories
{
    public class PetTypeRepository : IPetTypeRepository
    {
        public async Task<List<PetType>> GetAllAsync()
        {
            return new List<PetType>
            {
                new PetType()
                {
                    Id = Guid.NewGuid(),
                    Type = "Cat"
                },
                new PetType()
                {
                    Id = Guid.NewGuid(),
                    Type = "Dog"
                },
                new PetType()
                {
                    Id = Guid.NewGuid(),
                    Type = "Parrot"
                }
            };
        }
    }
}
