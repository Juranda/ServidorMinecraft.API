using AutoMapper;
using ServidorMinecraft.API.Models.DTO.PetTypeDTOs;

namespace ServidorMinecraft.API.Models.Profiles
{
    public class PetTypeProfile : Profile
    {
        public PetTypeProfile()
        {
            CreateMap<Domain.PetType, PetType>()
                .ReverseMap();

            CreateMap<AddPetTypeRequest, Domain.PetType>();
            CreateMap<UpdatePetTypeRequest, Domain.PetType>();
        }
    }
}
