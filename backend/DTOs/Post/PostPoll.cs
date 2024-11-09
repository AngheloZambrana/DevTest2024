using backend.Entities;

namespace backend.DTOs.Post;

public class PostPoll
{
    public string? Name { get; set; }
    public List<PollOptions>? Options { get; set; }
}