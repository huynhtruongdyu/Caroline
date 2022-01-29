using AutoMapper;
using Caroline.Application.Interfaces.Repositories;
using Caroline.Shared.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Queries.Post
{
    public class GetPostByIdHandler : IRequestHandler<GetPostByIdQuery, PostModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPostByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<PostModel> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            var post = _unitOfWork.PostRepository.GetById(request.Id);
            var postModel = _mapper.Map<PostModel>(post);
            return Task.FromResult(postModel);
        }
    }
}