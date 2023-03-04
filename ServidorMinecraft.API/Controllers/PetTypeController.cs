using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServidorMinecraft.API.Models;
using ServidorMinecraft.API.Repositories;

namespace ServidorMinecraft.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetTypeController : ControllerBase
    {
        private readonly IPetTypeRepository petTypeRepository;
        private readonly IMapper mapper;

        public PetTypeController(IPetTypeRepository petTypeRepository, IMapper mapper)
        {
            this.petTypeRepository = petTypeRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPetTypesAsync()
        {
            var petTypes = await petTypeRepository.GetAllAsync();

            return Ok(petTypes);
        }

        [HttpGet]
        [Route("{id}")]
        [ActionName(nameof(GetPetTypeAsync))]
        public async Task<IActionResult> GetPetTypeAsync([FromRoute] Guid id)
        {
            var petType = await petTypeRepository.GetAsync(id);

            if (petType is null) return NotFound();

            return Ok(petType);
        }

        [HttpPost]
        public async Task<IActionResult> PostPetTypeAsync(Models.DTO.AddPetTypeRequest addPetTypeRequest)
        {
            var domainPetType = mapper.Map<Models.Domain.PetType>(addPetTypeRequest);

            domainPetType = await petTypeRepository.AddAsync(domainPetType);

            if (domainPetType is null) return NotFound();

            return CreatedAtAction(nameof(GetPetTypeAsync), new { id = domainPetType.Id }, domainPetType);
        }
    }
}
