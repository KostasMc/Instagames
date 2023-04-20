using System.Linq;
using Instagames.Database;
using Instagames.Entities.Domain_Models;

namespace Instagames.RepositoryService.Repositories
{
    public class DeveloperRepos:Repository<Developer>
    {

        public ApplicationDbContext DbContext
        {
            get { return Context as ApplicationDbContext; }
        }
        public DeveloperRepos(ApplicationDbContext context) : base(context)
        {

        }

        public bool DeveloperExists(int id)
        {
            return DbContext.Developers.Count(d => d.DeveloperId == id) > 0;
        }

    }
}
