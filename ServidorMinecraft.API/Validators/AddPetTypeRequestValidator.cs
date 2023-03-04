using FluentValidation;
using ServidorMinecraft.API.Models.DTO.PetTypeDTOs;

namespace ServidorMinecraft.API.Validators
{
    public class AddPetTypeRequestValidator : AbstractValidator<AddPetTypeRequest>
    {
        public AddPetTypeRequestValidator()
        {
            RuleFor(x => x.Type).NotEmpty();
        }
    }
}
