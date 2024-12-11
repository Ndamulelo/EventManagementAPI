namespace EventManagementAPI.Core.Entities
{
    public class Address : BaseEntity
    {
        public string? Caption { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public required string Country { get; set; }
        public required Event Event { get; set; }
        public required string EventId { get; set; }
    }
}