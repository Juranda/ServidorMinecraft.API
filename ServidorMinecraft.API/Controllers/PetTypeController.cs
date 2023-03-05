using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServidorMinecraft.API.Models.DTO.PetTypeDTOs;
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
        [Authorize(Roles = "read")]
        public async Task<IActionResult> GetAllPetTypesAsync()
        {
            var petTypes = await petTypeRepository.GetAllAsync();

            var petTypeDTOs = mapper.Map<List<PetType>>(petTypes);

            return Ok(petTypeDTOs);
        }

        [HttpGet]
        [Route("{id:guid}")]
        [Authorize(Roles = "read")]
        [ActionName(nameof(GetPetTypeAsync))]
        public async Task<IActionResult> GetPetTypeAsync([FromRoute] Guid id)
        {
            var petType = await petTypeRepository.GetAsync(id);

            if (petType is null) return NotFound();

            var petTypeDTO = mapper.Map<PetType>(petType);

            return Ok(petTypeDTO);
        }

        [HttpPost]
        [Authorize(Roles = "create")]
        public async Task<IActionResult> PostPetTypeAsync(AddPetTypeRequest addPetTypeRequest)
        {
            var petType = mapper.Map<Models.Domain.PetType>(addPetTypeRequest);

            petType = await petTypeRepository.AddAsync(petType);

            if (petType is null) return NotFound();

            var petTypeDTO = mapper.Map<PetType>(petType);

            return CreatedAtAction(nameof(GetPetTypeAsync), new { id = petTypeDTO.Id }, petTypeDTO);
        }

        [HttpPut]
        [Route("{id:guid}")]
        [Authorize(Roles = "update")]
        public async Task<IActionResult> PutPetTypeAsync(
            [FromRoute] Guid id, 
            [FromBody] UpdatePetTypeRequest putPetTypeRequest)
        {
            var petType = mapper.Map<Models.Domain.PetType>(putPetTypeRequest);

            petType = await petTypeRepository.UpdateAsync(id, petType);

            if (petType is null) return NotFound();

            var petTypeDTO = mapper.Map<PetType>(petType);

            return Ok(petTypeDTO);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        [Authorize(Roles = "delete")]
        public async Task<IActionResult> DeletePetTypeAsync(Guid id)
        {
            var petDeleted = await petTypeRepository.DeleteAsync(id);
            if (petDeleted is null) return NotFound();

            var petTypeDTO = mapper.Map<PetType>(petDeleted);

            return Ok(petTypeDTO);
        }
    }
}
