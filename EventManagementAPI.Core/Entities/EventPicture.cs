namespace EventManagementAPI.Core.Entities
{
    public class EventPicture : BaseEntity
    {
        public required string FileName { set; get; }
        public required Event Event { set; get; }
        public string EventId { set; get; }
    }
}