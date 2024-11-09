using AutoMapper;
using backend.DTOs;
using backend.DTOs.Post;
using backend.Entities;

namespace backend.Profiles;

public class PollOptionsProfile : Profile
{
    public PollOptionsProfile()
    {
        CreateMap<PollOptions, PollOptionsDTO>().ReverseMap();
        CreateMap<(PostPollOption p, int id), PollOptions>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.p.Name))
            .ForMember(dest => dest.Votes, opt => opt.MapFrom(src => src.p.Votes)).ReverseMap();
    }
}