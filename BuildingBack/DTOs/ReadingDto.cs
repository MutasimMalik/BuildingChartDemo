using System;

namespace BuildingBack.DTOs
{
    public class ReadingDto
    {
        public int BuildingId { get; set; }
        public int ObjectId { get; set; }
        public int DataFieldId { get; set; }
        public decimal Value { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
