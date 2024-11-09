using AutoMapper;
using backend.DTOs;
using backend.Entities;
using backend.Repositories;
using backend.Services.Interfaces;

namespace backend.Services;

public class PollService : IPollService
{
    private PollRepository _pollRepository;

    public PollService()
    {
        _pollRepository = new PollRepository();
    }
    
    public Task<List<Polls>> GetAllPolls()
    {
        return _pollRepository.GetAll();
    }

    public Task<Polls> CreatePoll(Polls poll)
    {
        return _pollRepository.Crete(poll);
    }
}