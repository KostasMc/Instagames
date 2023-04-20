using Instagames.Database;
using Instagames.Entities.Domain_Models;

namespace Instagames.RepositoryService.Repositories
{
    public class UserGameRatingsRepos : Repository<UserGameRatings>
    {
        public ApplicationDbContext DbContext
        {
            get { return Context as ApplicationDbContext; }
        }
        public UserGameRatingsRepos(ApplicationDbContext context) : base(context)
        {

        }
    }
}
