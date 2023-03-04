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
    }
}
