using backend.Entities;

namespace backend.Services.Interfaces;

public interface IVoteService
{
    public Task<List<Vote>> GetAllVotesAsync();
    public Task<Vote> CreateVote(Vote vote);
}