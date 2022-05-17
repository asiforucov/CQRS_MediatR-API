using System;

namespace CQRS_MediatR_API.MediatR.Queries
{
    public class GetProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
