using backend.DTOs;
using backend.Entities;
using backend.Entities.Interface;
using backend.Repositories;
using backend.Services.Interfaces;

namespace backend.Services;

public class VoteService : IVoteService
{
    private VoteRepository _repository;
    private PollRepository _pollRepository;

    public VoteService(PollRepository pollRepository)
    {
        _pollRepository = pollRepository;
        _repository = new VoteRepository();
    }

    public Task<List<Vote>> GetAllVotesAsync()
    {
        return _repository.GetAll();
    }
    
    public Task<Vote> CreateVote(Vote vote)
    {
        return _repository.Crete(vote);
    }
}