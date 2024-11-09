using AutoMapper;
using backend.DTOs;
using backend.DTOs.Post;
using backend.Entities;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VoteController : ControllerBase
{
    private readonly IVoteService _voteService;
    private readonly IMapper _mapper;
    private const int contador = 3;

    public VoteController(IVoteService voteService, IMapper mapper)
    {
        _voteService = voteService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<VoteDTO>>> GetAllVotes()
    {
        var votes = await _voteService.GetAllVotesAsync();
        var voteDto = _mapper.Map<List<VoteDTO>>(votes);
        Console.WriteLine(voteDto);
        return Ok(voteDto);
    }
    
    [HttpPost]
    public async Task<ActionResult<VoteDTO>> Post(PostVote postVote)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var voteEntity = _mapper.Map<Vote>((postVote,contador));
        var result = await _voteService.CreateVote(voteEntity);
        return Ok(_mapper.Map<VoteDTO>(result));
    }
}