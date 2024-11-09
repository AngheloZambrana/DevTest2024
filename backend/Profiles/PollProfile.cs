using AutoMapper;
using backend.DTOs;
using backend.DTOs.Post;
using backend.Entities;

namespace backend.Profiles;

public class PollProfile : Profile
{
    public PollProfile()
    {
        CreateMap<Polls, PollDTO>();
        CreateMap<PollDTO, Polls>();
        CreateMap<(PostPoll p, Guid id), Polls>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.p.Name))
            .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.p.Options)).ReverseMap();
            
    }
}