namespace backend.DTOs;

public class VoteDTO
{
    public int Id { get; set; }
    public int PollId { get; set; }
    public int PostOptionId { get; set; }   
    public string? VoteEmail { get; set; }
}