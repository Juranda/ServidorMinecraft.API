using Microsoft.EntityFrameworkCore;
using ServidorMinecraft.API.Data;
using ServidorMinecraft.API.Models.Domain;

namespace ServidorMinecraft.API.Repositories
{
    public class PetTypeRepository : IPetTypeRepository
    {
        private readonly MinecraftServerDbContext context;

        public PetTypeRepository(MinecraftServerDbContext context)
        {
            this.context = context;
        }
        public async Task<List<PetType>> GetAllAsync()
        {
            return await context.PetTypes.ToListAsync();
        }

        public async Task<PetType> GetAsync(Guid id)
        {
            return await context.PetTypes.FirstOrDefaultAsync(pt => pt.Id == id);
        }

        public async Task<PetType> AddAsync(PetType petType)
        {
            petType.Id = Guid.NewGuid();

            await context.PetTypes.AddAsync(petType);
            await context.SaveChangesAsync();

            return petType;
        }
    }
}
