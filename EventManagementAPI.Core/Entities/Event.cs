using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace EventManagementAPI.Core.Entities
{
	public class Event : BaseEntity
	{
        public required string Name { set; get; }
        public required string Description { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public required EventPicture EventPicture { set; get; }
        public string EventPictureId { set; get; }
        public required Address Address { set; get; }
        public string AddressId { set; get; }
        public ICollection<Category>? Categories { set; get; }
        public ICollection<Price>? Prices { set; get; }
        public required bool IsAdultOnly { set; get; }
    }
}