using backend.Entities;

namespace backend.DTOs;

public class PollDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<PollOptions>? Options { get; set; }
}