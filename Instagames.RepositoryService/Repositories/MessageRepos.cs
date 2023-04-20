using System.Data.Entity;
using System.Linq;
using Instagames.Database;
using Instagames.Entities.Domain_Models;

namespace Instagames.RepositoryService.Repositories
{
    public class MessageRepos : Repository<Message>
    {
        public ApplicationDbContext DbContext
        {
            get { return Context as ApplicationDbContext; }
        }

        public MessageRepos(DbContext context) : base(context)
        {
        }

        public bool MessageExists(int id)
        {
            return DbContext.Messages.Count(m => m.MessageId == id) > 0;
        }
    }
}
