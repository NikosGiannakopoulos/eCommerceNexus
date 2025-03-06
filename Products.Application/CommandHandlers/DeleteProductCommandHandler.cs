using MediatR;
using Products.Application.Commands;

namespace Products.Application.CommandHandlers
{
    class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        public Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}