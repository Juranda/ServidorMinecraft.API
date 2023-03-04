using AutoMapper;

namespace ServidorMinecraft.API.Models.Profiles
{
    public class PetTypeProfile : Profile
    {
        public PetTypeProfile()
        {
            CreateMap<Domain.PetType, DTO.PetType>()
                .ReverseMap();

            CreateMap<DTO.AddPetTypeRequest, Domain.PetType>();
            CreateMap<DTO.PutPetTypeRequest, Domain.PetType>();
        }
    }
}
