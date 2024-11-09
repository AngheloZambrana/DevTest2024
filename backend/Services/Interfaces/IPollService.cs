using backend.Entities;

namespace backend.Services.Interfaces;

public interface IPollService
{
    public Task<List<Polls>> GetAllPolls();
    public Task<Polls> CreatePoll(Polls poll);
}