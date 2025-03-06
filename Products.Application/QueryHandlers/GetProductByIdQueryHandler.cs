using MediatR;
using Products.Application.Queries;

namespace Products.Application.QueryHandlers
{
    class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery>
    {
        public Task Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}