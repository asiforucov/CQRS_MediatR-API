using MediatR;
using System;

namespace CQRS_MediatR_API.MediatR.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
