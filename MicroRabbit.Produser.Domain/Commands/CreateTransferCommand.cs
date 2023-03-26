
namespace MicroRabbit.Produser.Domain.Commands
{
    public class CreateTransferCommand: TransferCommand
    {
        public CreateTransferCommand(int id, string name, int userId)
        {
            Id = id;
            Name = name;
            UserId = userId;
        }
    }
}
