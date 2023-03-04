using FluentValidation;
using ServidorMinecraft.API.Models.DTO.PetTypeDTOs;

namespace ServidorMinecraft.API.Validators
{
    public class UpdatePetTypeRequestValidator : AbstractValidator<UpdatePetTypeRequest>
    {
        public UpdatePetTypeRequestValidator()
        {
            RuleFor(x => x.Type).NotEmpty();
        }
    }
}
