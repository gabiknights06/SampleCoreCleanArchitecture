using Sample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Models
{
    public class Company : ICompany
    {
        public Company()
        {
            Name = string.Empty;
            Address = string.Empty;
            Id = 0;
            RecordState = 0;
            Timestamp = DateTime.Now;
            ModifiedTimestamp = DateTime.Now;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public int RecordState { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
    }
}
