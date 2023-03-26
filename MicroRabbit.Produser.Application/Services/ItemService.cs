
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Produser.Application.Interfaces;
using MicroRabbit.Produser.Application.Models;
using MicroRabbit.Produser.Domain.Commands;

namespace MicroRabbit.Produser.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IEventBus _bus;

        public ItemService(IEventBus bus)
        {
            _bus = bus;
        }
        
        public void Transfer(ItemTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                    accountTransfer.Id,
                    accountTransfer.Name,
                    accountTransfer.UserId
                );

            _bus.SendCommand(createTransferCommand);
        }
    }
}
