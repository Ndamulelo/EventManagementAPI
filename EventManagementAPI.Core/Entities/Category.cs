namespace EventManagementAPI.Core.Entities
{
    public class Category : BaseEntity
    {
        public required string Name { set; get; }
        public ICollection<Event>? Events { set; get; }
    }
}