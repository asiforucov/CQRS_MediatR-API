﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_MediatR_API.MediatR.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductViewModel>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
        {
            public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model = new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Book"
                };
                var model2 = new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Notebook"
                };
                return Task.FromResult(new List<GetProductViewModel>() { model,model2});
            }
        }
    }
}
