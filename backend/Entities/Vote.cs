using backend.Entities.Interface;

namespace backend.Entities;

public class Vote : ID
{
    public int Id { get; set; }
    public int PollId { get; set; }
    public int PostOptionId { get; set; }   
    public string? VoteEmail { get; set; }
}