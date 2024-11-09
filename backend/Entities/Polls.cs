using backend.Entities.Interface;

namespace backend.Entities;

public class Polls : ID
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<PollOptions>? Options { get; set; }
}