using MicroRabbit.Domain.Core.Commands;


namespace MicroRabbit.Produser.Domain.Commands
{
    public abstract class TransferCommand: Command
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int UserId { get; protected set; }
    }
}
