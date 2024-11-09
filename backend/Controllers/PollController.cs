using AutoMapper;
using backend.DTOs;
using backend.DTOs.Post;
using backend.Entities;
using backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PollController : ControllerBase
{
    private readonly IPollService _pollService;
    private readonly IMapper _mapper;

    public PollController(IPollService pollService, IMapper mapper)
    {
        _pollService = pollService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<PollDTO>>> GetAll()
    {
        var polls = await _pollService.GetAllPolls();
        var pollDto = _mapper.Map<List<PollDTO>>(polls);
        return Ok(pollDto);
    }

    [HttpPost]
    public async Task<ActionResult<PollDTO>> Post(PostPoll postPoll)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState);
        var pollEntity = _mapper.Map<Polls>((postPoll, 4));
        var result = await _pollService.CreatePoll(pollEntity);
        return Ok(_mapper.Map<PollDTO>(result));
    }
}