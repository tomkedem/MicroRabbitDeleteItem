
using MicroRabbit.Domain.Core.Events;


namespace MicroRabbit.Produser.Domain.Events
{
    public class TransferCreatedEvent: Event
    {
        public int Id {  get; private set; }
        public string Name { get; private set; }
        public int UserId { get; private set; }

        public TransferCreatedEvent(int id, string name, int userId)
        {
            Id = id;
            Name = name;
            UserId = userId;
        }       
    }
}
