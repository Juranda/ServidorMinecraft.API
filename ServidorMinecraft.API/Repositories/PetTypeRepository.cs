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

        public async Task<PetType> UpdateAsync(Guid id, PetType petType)
        {
            var petTypeDomain = await context.PetTypes.FirstOrDefaultAsync(pt => pt.Id == id);
            if (petTypeDomain is null) return petTypeDomain;

            petTypeDomain.Type = petType.Type;
            await context.SaveChangesAsync();

            return petTypeDomain; 
        }

        public async Task<PetType> DeleteAsync(Guid id)
        {
            var petType = await context.PetTypes.FirstOrDefaultAsync(pt => pt.Id == id);
            if (petType is null) return petType;

            context.PetTypes.Remove(petType);
            await context.SaveChangesAsync();

            return petType;
        }
    }
}
