using Caroline.Application.Interfaces.Repositories.Posts;

namespace Caroline.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}