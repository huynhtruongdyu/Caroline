using AutoMapper;
using Caroline.Application.Interfaces.Repositories;
using Caroline.Shared.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Queries.Post
{
    public class GetAllPostHandler : IRequestHandler<GetAllPostQuery, List<PostModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllPostHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<List<PostModel>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
        {
            var postsFromDB = _unitOfWork.PostRepository.GetAll();
            var postsModel = _mapper.Map<List<PostModel>>(postsFromDB);
            return Task.FromResult(postsModel);
        }
    }
}