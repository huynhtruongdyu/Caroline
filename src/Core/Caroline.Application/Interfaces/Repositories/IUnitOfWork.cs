using Caroline.Application.Interfaces.Repositories.Categories;

namespace Caroline.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }
    }
}