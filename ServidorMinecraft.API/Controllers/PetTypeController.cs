using Microsoft.AspNetCore.Mvc;
using ServidorMinecraft.API.Models.Domain;
using ServidorMinecraft.API.Repositories;
using System.Collections;

namespace ServidorMinecraft.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetTypeController : ControllerBase
    {
        private readonly IPetTypeRepository petTypeRepository;

        public PetTypeController(IPetTypeRepository petTypeRepository)
        {
            this.petTypeRepository = petTypeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPetTypesAsync()
        {
            var petTypes = await petTypeRepository.GetAllAsync();

            return Ok(petTypes);
        }
    }
}
