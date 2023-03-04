using AutoMapper;

namespace ServidorMinecraft.API.Models.Profiles
{
    public class PetTypeProfile : Profile
    {
        public PetTypeProfile()
        {
            CreateMap<Domain.PetType, DTO.PetType>()
                .ReverseMap();

            CreateMap<Domain.PetType, DTO.AddPetTypeRequest>()
                .ReverseMap();
        }
    }
}
