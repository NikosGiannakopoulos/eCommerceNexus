using MediatR;
using Products.Application.Queries;

namespace Products.Application.QueryHandlers
{
    class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery>
    {
        public Task Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}