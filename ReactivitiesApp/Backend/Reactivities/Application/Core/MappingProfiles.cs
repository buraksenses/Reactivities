using AutoMapper;
using Reactivities.Data.Domain;

namespace Reactivities.Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Activity, Activity>().ReverseMap();
    }
}