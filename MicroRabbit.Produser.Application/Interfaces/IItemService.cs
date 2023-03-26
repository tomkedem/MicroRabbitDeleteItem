using MicroRabbit.Produser.Application.Models;

namespace MicroRabbit.Produser.Application.Interfaces
{
    public interface IItemService
    {
        void Transfer(ItemTransfer itemTransfer);
    }
}
