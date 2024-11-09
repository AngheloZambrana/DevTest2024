using backend.DTOs;
using backend.Entities;
using backend.Repositories;
using backend.Services.Interfaces;

namespace backend.Services;

public class VoteService : IVoteService
{
    private VoteRepository _repository;

    public VoteService()
    {
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