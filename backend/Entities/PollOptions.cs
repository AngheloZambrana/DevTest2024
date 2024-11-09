using backend.Entities.Interface;

namespace backend.Entities;

public class PollOptions : ID
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Votes { get; set; }
}
