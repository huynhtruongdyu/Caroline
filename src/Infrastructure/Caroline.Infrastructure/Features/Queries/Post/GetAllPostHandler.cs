using Caroline.Application.Interfaces.Repositories;
using Caroline.Infrastructure.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Queries.Post
{
    public class GetAllPostHandler : IRequestHandler<GetAllPostQuery, List<PostModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllPostHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<PostModel>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
        {
            var postsFromDB = _unitOfWork.PostRepository.GetAll();
            var postsModel = postsFromDB.Select(post => new PostModel { Id = post.Id, Title = post.Title, Content = post.Content, ThumbnailURL = post.Thumbnail, CreatedDate = post.CreatedDate, CreatedBy = post.CreatedBy }).ToList();
            return Task.FromResult(postsModel);
        }
    }
}