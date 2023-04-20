using System;
using System.Threading.Tasks;
using Instagames.RepositoryService.Repositories;

namespace Instagames.RepositoryService
{
    public interface IUnitOfWork : IDisposable
    {
        GameRepos Games { get; }
        DeveloperRepos Developer { get; }
        CategoryRepos Category { get; }
        MessageRepos Message { get; }
        PegiRepos Pegi { get; }
        UserGameRatingsRepos UserGameRatings { get; }

        void Save();

        Task<int> SaveAsync();
    }
}
