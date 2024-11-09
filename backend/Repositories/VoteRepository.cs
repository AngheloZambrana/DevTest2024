using backend.Entities;
using backend.Repositories.Utils;

namespace backend.Repositories;

public class VoteRepository : AbstractRepository<Vote>
{
    public VoteRepository()
    {
        data = new List<Vote>()
        {
            new Vote()
            {
                Id = 1,
                PollId = 2,
                PostOptionId = 3,
                VoteEmail = "froddo.baggins@middle-earth.com"
            },
            new Vote()
            {
                Id = 2,
                PollId = 3,
                PostOptionId = 2,
                VoteEmail = "anghelekzq@gmail.com"
            }
        };
    }
    
}