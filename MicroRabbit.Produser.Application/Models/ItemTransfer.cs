namespace MicroRabbit.Produser.Application.Models
{
    public class ItemTransfer
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public int UserId { get; set; }
    }
}
