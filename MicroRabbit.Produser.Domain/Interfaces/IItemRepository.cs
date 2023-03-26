
using MicroRabbit.Produser.Domain.Model;

namespace MicroRabbit.Produser.Domain.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Item> DeleteItem();
    }
}
