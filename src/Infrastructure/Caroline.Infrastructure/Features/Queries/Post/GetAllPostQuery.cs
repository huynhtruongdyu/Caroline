﻿using Caroline.Shared.Models.Post;
using MediatR;

namespace Caroline.Infrastructure.Features.Queries.Post
{
    public class GetAllPostQuery : IRequest<List<PostModel>> { };
}