using MediatR;
using Products.Application.Commands;

namespace Products.Application.CommandHandlers
{
    class UpsertProductCommandHandler : IRequestHandler<UpsertProductCommand>
    {
        public Task Handle(UpsertProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}