using System;
namespace EventManagementAPI.Core.Entities
{
	public class BaseEntity
	{
        public required string Id { set; get; }
        public DateTime CreatedDate { set; get; }
    }
}