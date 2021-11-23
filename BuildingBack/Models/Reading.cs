using System;

namespace BuildingBack.Models
{
    public class Reading
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public int ObjectId { get; set; }
        public int DataFieldId { get; set; }
        public decimal Value { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
