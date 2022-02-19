using AutoMapper;
using Caroline.Application.Interfaces.Repositories;
using Caroline.Domain.Categories;
using Caroline.Shared.Models.Mediator;
using MediatR;

namespace Caroline.Infrastructure.Features.Commands.Posts
{
    public class CreatePostHandler : IRequestHandler<CreatePostCommand, RequestResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreatePostHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<RequestResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var post = _mapper.Map<Post>(request.model);
                _unitOfWork.PostRepository.Insert(post);
                await _unitOfWork.SaveChangesAsync();
                return new RequestResponse() { IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new RequestResponse() { IsSuccess = false, Message = ex.Message };
            }
        }
    }
}