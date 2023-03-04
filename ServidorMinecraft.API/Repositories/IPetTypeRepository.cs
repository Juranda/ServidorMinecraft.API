using ServidorMinecraft.API.Models.Domain;

namespace ServidorMinecraft.API.Repositories
{
    public interface IPetTypeRepository
    {
        Task<List<PetType>> GetAllAsync();
        Task<PetType> GetAsync(Guid id);
        Task<PetType> AddAsync(PetType petType);
        Task<PetType> UpdateAsync(Guid id, PetType petType);
        Task<PetType> DeleteAsync(Guid id);
    }
}
