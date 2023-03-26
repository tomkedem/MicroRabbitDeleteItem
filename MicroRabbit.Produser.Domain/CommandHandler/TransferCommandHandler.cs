using MediatR;
using MicroRabbit.Produser.Domain.Commands;
using MicroRabbit.Produser.Domain.Events;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Produser.Domain.CommandHandler
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;
        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            // publish event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.Id, request.Name, request.UserId));

            return Task.FromResult(true);
        }
    }
}
