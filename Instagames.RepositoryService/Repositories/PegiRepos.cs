using System.Data.Entity;
using Instagames.Database;
using Instagames.Entities.Domain_Models;

namespace Instagames.RepositoryService.Repositories
{
    public class PegiRepos :Repository<Pegi>
    {
        public ApplicationDbContext DbContext
        {
            get { return Context as ApplicationDbContext; }
        }
        public PegiRepos(DbContext context) : base(context)
        {
        }
    }
}
