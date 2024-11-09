using AutoMapper;
using backend.DTOs;
using backend.DTOs.Post;
using backend.Entities;

namespace backend.Profiles;

public class VoteProfile : Profile
{
    public VoteProfile()
    {
        CreateMap<Vote, VoteDTO>().ReverseMap();
        CreateMap<(PostVote p, int id), Vote>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
            .ForMember(dest => dest.PollId, opt => opt.Ignore())
            .ForMember(dest => dest.PostOptionId, opt => opt.MapFrom(src => src.p.PostOptionId))
            .ForMember(dest => dest.VoteEmail, opt => opt.MapFrom(src => src.p.VoteEmail)).ReverseMap();
    }
}