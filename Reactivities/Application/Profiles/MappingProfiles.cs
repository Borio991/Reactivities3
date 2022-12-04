using AutoMapper;
using Domain;

namespace Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity , Activity>();
        }
    }
}