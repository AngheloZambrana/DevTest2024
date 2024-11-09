using backend.Entities;
using backend.Repositories.Utils;

namespace backend.Repositories;

public class PollRepository : AbstractRepository<Polls>
{
    public PollRepository()
    {
        data = new List<Polls>()
        {
            new Polls()
            {
                Id = 1,
                Name = "Favorite Programming Language",
                Options = new List<PollOptions>
                {
                    new PollOptions {Id = 1, Name = "JavaScript", Votes = 1},
                    new PollOptions {Id = 2, Name = "C#", Votes = 2}
                },
            }
        };
    }
}