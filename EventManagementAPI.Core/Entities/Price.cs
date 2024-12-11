namespace EventManagementAPI.Core.Entities
{
    public class Entrance : BaseEntity
    {
        public required decimal EntranceFee { set; get; }
        public required string Description { set; get; }
        public required string Package { set; get; }
        public required Event Event { set; get; }
        public string EventId { set; get; }
    }
}