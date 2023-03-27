
namespace MicroRabbit.Produser.Domain.Model
{
    public class Item    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public int UserId { get; set; }
    }
}
